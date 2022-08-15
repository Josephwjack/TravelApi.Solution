using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Destination>()
          .HasData(
            new Destination { DestinationId = 1, Name = "Space Needle", State = "Washington", Country = "United States" },
            new Destination { DestinationId = 2, Name = "Portland", State = "Oregon", Country = "United States" },
            new Destination { DestinationId = 3, Name = "Vancouver", State = "British Columbia", Country = "Canada" }
          );
        }
    }
}