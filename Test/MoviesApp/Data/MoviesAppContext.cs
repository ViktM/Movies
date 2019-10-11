using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;

namespace MoviesApp.Data
{
    public class MoviesAppContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MoviesAppContext(
            DbContextOptions<MoviesAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

} 