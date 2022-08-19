using Booker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Booker.Domain
{
    public class BookerDbContext : DbContext
    {

        public BookerDbContext(DbContextOptions<BookerDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Movie> Movies{ get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //            .SetBasePath(Directory.GetCurrentDirectory())
        //            .AddJsonFile("appsettings.json")
        //            .Build();

        //        var connectionString = configuration.GetConnectionString("Db_Connection");
        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}

        //public async Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    //this.EnsureExternalIdsAreSet();
        //    Int32 result;
        //    result = await base.SaveChangesAsync(cancellationToken);
        //    return result;
        //}
    }
}