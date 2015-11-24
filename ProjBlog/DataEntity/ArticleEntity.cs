using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using ProjBlog.DataEntity;
namespace ProjBlog.DataEntity
{
    public class ArticleEntity
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ArticleEntity));
        private DbEntity db;
        public ArticleEntity()
        { 

        }
    }
}