using Microsoft.EntityFrameworkCore;
using NotissimusTesting.DAL.Models.Offers;

namespace NotissimusTesting.DAL.DB
{
    public class WebAppContext : DbContext
    {
        DbSet<Offer> offers { get; set; }
        DbSet<ArtistTitle> artists { get; set; }
        DbSet<AudioBook> books { get; set; }
        DbSet<EventTicket> ticket { get; set; }
        DbSet<Tour> tours { get; set; }
        DbSet<VendorModel> vendorModels { get; set; }
    }
} 