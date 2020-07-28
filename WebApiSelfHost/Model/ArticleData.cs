using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSelfHost.Model
{
    public class ArticleData
    {
        /// <summary>
        /// 文章标题.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 文章作者.
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// 文章分类.
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// 来源.
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// 文章内容.
        /// </summary>
        public string content { get; set; }
    }
}
