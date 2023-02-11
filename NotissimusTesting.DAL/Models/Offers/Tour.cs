using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class Tour : Offer
    {
        public string WorldRegion { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Days { get; set; }
        public DateOnly StartDateTour { get; set; }
        public DateOnly EndDateTour { get { return StartDateTour.AddDays(Days); } }
        public string Name { get; set; }
        public string HotelStars { get; set; }
        public string Room { get; set; }
        public string Meal { get; set; }
        public string Included { get; set; }
        public string Transport { get; set;}
    }
}
