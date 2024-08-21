using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) => Database.EnsureCreated();

        public DbSet<Movie> Movies { get; set; }
    }
}