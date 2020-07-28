using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSelfHost.Model
{
    public class CommonReq
    {
        /// <summary>
        /// sign
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 业务参数数据
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// 调用接口名
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// 请求特征值
        /// 提交时产生，作为本次请求的唯一标识，
        /// 当请求被接受或者处理完成回调时会返回此请求值，
        /// 以防止第三方伪造回调。
        /// </summary>
        public string requesttoken { get; set; }
    }
}
