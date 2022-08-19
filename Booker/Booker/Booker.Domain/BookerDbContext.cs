using Booker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
               getEntitySeedValues<Customer>()
            ); 
            builder.Entity<Movie>().HasData(
                getEntitySeedValues<Movie>()
            );
        }

        public List<T> getEntitySeedValues<T>()
        {
            var itemvalue = new List<T>();
            String type = typeof(T).Name;
            using (StreamReader r = new StreamReader($"../Booker.Domain/Seed/{type}s.json"))
            {
                string json = r.ReadToEnd();
                itemvalue = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return itemvalue;
        }


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