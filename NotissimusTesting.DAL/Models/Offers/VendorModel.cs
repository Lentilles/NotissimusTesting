using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class VendorModel : Offer
    {
        public string TypePrefix { get; set; }
        public string Vendor { get; set; }
        public string VendorCode { get; set; }
        public string Model { get; set; }
        public bool ManufacturerWarranty { get; set; }
    }
}
