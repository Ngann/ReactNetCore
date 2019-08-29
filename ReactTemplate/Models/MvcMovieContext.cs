using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options; 

namespace ReactTemplate.Models
{
    public class MvcMovieContext : DbContext
    {
        private ConnectionStringsConfig _connectionStrings;

        public MvcMovieContext(IOptionsSnapshot<ConnectionStringsConfig> connectionStrings)
        {
            _connectionStrings = connectionStrings?.Value ?? throw new ArgumentNullException(nameof(connectionStrings));
        }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_connectionStrings.Movies);

        public DbSet<Movie> Movie { get; set; }
    }

    public class ConnectionStringsConfig
    {
        public string Movies { get; set; }
        public string OtherDatabase { get; set; }
    }
}
