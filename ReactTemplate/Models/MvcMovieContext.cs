using System;
using Microsoft.EntityFrameworkCore;

namespace ReactTemplate.Models
{
    public class MvcMovieContext : DbContext
    {
        //public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Database=my_d;Host=localhost;Port=5432");

        public DbSet<Movie> Movie { get; set; }
    }
}
