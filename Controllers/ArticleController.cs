using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanTattoosNow.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanTattoosNow.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleController(IArticleRepository articleRepository)
        {
            this._articleRepository = articleRepository;
        }

        [HttpGet]
        [Route("Article/{Id}")]
        public Article GetArticle(int Id)
        {
            Article article = _articleRepository.GetArticles(Id);
            return article;
            
        }
    }
}