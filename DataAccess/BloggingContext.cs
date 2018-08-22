using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EasyPubl.DataAccess
{
    public class BloggingContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }

}