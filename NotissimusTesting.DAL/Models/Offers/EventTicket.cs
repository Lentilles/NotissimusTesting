using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class EventTicket : Offer
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string PlanUrl { get; set; }
        public string PlanDescription { get; set; }
        public string HallPart { get; set; }
        public DateTime Date { get; set; }
        public bool isPremiere { get; set; }
        public bool isKids { get; set; }
    }
}
