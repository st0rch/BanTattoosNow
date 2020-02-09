using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanTattoosNow.Models
{
    public class ArticleRepository : IArticleRepository
    {

        public ArticleRepository(BanTattoosNowContext context)
        {
            this.context = context;
        }
       
        private readonly BanTattoosNowContext context;

        public Article GetArticles(int Id)
        {
            return context.Article.Find(Id);
        }
    }
}
