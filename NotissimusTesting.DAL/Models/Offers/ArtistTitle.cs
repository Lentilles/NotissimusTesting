using NotissimusTesting.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotissimusTesting.DAL.Models.Offers
{
    public class ArtistTitle : Offer, IMediaStorage, IYear
    {
        public string? Artist { get; set; }
        public List<string>? Starring { get; set; }
        public string Title { get; set; }

        #region IYear
        public short Year { get; set; }
        #endregion

        #region IMediaStorage
        public string MediaStorage { get; set; }
        #endregion
    }
}
