using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)

        {

        }
        public DbSet<Catagory> Catagory { get; set; }
        public DbSet<Product> Products { get; set; }



    }
}

