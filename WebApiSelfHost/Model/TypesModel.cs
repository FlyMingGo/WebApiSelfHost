using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSelfHost.Model
{
    public class TypesModel
    {
        public enum Source
        {
            Wechat,
            Sina,
            Toutiao,
            Lahoo
        }

        public enum Operation
        {
            ArticleCrawl,
            ArticleGet
        }
    }

    public class ArticleInfo
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }
    }
}
