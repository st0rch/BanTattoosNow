using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanTattoosNow.Models
{
    public interface IArticleRepository
    {
        Article GetArticles(int Id);
    }
}
