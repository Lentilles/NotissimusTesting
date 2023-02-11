using NotissimusTesting.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class AudioBook : Offer, IComposition, IMediaStorage, IYear
    {
        public string RecLenght { get; set; }
        public string PerformedBy { get; set; }
        public string PerformanceType { get; set; }
        public string Format { get; set; }

        #region IComposition
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public bool Downloadable { get; set; }
        #endregion

        #region IYear
        public short Year { get; set; }
        #endregion

        #region IMediaStorage
        public string MediaStorage { get; set; }
        #endregion
    }
}
