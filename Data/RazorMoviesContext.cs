using Microsoft.EntityFrameworkCore;
using RazorMovies.Models;

namespace RazorMovies.Data
{
    public class RazorMoviesContext : DbContext
    {
        public RazorMoviesContext (DbContextOptions<RazorMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMovies.Models.Movie> Movie { get; set; }

        public DbSet<RazorMovies.Models.Director> Director { get; set; }
    }
}
