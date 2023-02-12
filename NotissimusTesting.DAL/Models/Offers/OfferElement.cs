using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class OfferElement
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Offer))]
        public int OfferId { get; set; }
        public Offer Offer {get; set;}
        public string ElementName { get; set; }
        public string Value { get; set; }
    }
}
