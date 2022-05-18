using AlphaVenteData.model;
using Microsoft.EntityFrameworkCore;

namespace AlphaVenteApi.Data
{
    public class AlphaDbContext:DbContext
    {
        public AlphaDbContext(DbContextOptions<AlphaDbContext>options):base(options)    
        {

        }
        public DbSet<Customer> Customers { get; set; }

    }
}
