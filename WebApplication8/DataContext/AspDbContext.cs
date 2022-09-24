using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.DataContext
{
    public class AspDbContext :DbContext
    {
    public DbSet<User> Users { get; set; }
    public DbSet<Note> Notes { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost; database = test; uid = sa; password = alencia");
        }


    }
}
