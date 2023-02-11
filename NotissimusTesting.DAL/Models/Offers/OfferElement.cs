using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public  class OfferElement
    {
        [Key]
        public int Id { get; set; }
        public int OfferId { get; set; }
        public string ElementName { get; set; }
        public string Value { get; set; }
    }
}
