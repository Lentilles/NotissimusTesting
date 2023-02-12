using Microsoft.EntityFrameworkCore;
using NotissimusTesting.DAL.Models.Offers;

namespace NotissimusTesting.DAL.DB
{
    public class WebAppContext : DbContext
    {
        public DbSet<Offer> offers { get; set; }
        public DbSet<OfferElement> offerElements { get; set; }

        public WebAppContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NotissimusTesting;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
} 