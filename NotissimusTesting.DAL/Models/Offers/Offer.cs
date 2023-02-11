using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class Offer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Bid { get; set; }
        public int? Cbid { get; set; }
        public string CurencyId { get; set; }
        public string PictureURL { get; set; }
        public bool Delivery { get; set; }
        [ForeignKey(nameof(category))]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public decimal LocalDeliveryCost { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool Available { get; set; }
        public string? Country { get; set; }
    }
}
