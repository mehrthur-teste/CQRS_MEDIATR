using Api_CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_CQRS
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {


        }

    }


    
}