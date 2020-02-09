using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BanTattoosNow.Models
{
    public partial class BanTattoosNowContext : DbContext
    {
        public BanTattoosNowContext(DbContextOptions<BanTattoosNowContext> options)
            : base(options)
        {

        }


        public DbSet<Article> Article { get; set; }
    }
}
