using NotissimusTesting.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class Book : Offer, IComposition, IYear
    {
        public string Series { get; set; }
        public short Volume { get; set; }
        public string Binding { get; set; }
        public int PageExtent { get; set; }
        public short Part { get; set; }

        #region IComposition
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public bool Downloadable { get; set; }
        public string Language { get; set; }
        #endregion

        #region IYear
        public short Year { get; set; }
        #endregion

    }
}
