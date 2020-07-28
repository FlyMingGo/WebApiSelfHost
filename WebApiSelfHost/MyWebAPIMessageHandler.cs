using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApiSelfHost.Model;

namespace WebApiSelfHost
{
    class MyWebAPIMessageHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var reqTask = request.Content.ReadAsStringAsync();
            string reqContent = reqTask.Result;
            var task = new Task<HttpResponseMessage>(() =>
            {
                var resMsg = new HttpResponseMessage();
                string dateStamp = GetTimeStamp();

                CommonReq crq = new CommonReq
                {
                    timestamp = dateStamp,
                    version = "1.0",
                    method = TypesModel.Operation.ArticleCrawl.ToString(),
                    requesttoken = Guid.NewGuid().ToString()
                };
                DataRes dr = new DataRes
                {
                    result_code = "1",
                    result_msg = "success"
                };
                crq.data = JsonConvert.SerializeObject(dr);
                var sendContent = JsonConvert.SerializeObject(crq);
                resMsg.Content = new StringContent(sendContent, System.Text.Encoding.UTF8, "application/json");
                return resMsg;
            });

            task.Start();
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(reqContent);
            return task;
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns>sring</returns>
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
