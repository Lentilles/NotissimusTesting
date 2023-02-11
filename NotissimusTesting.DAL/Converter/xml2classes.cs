using NotissimusTesting.DAL.Models.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NotissimusTesting.DAL.Converter
{
    public class xml2classes
    {
        private Dictionary<string, Type> XML2ClassType = new Dictionary<string, Type>()
        {
            {"vendor.model", typeof(VendorModel)},
            {"book", typeof(Book) },
            {"audiobook", typeof(AudioBook) },
            {"artist.title", typeof(ArtistTitle) },
            {"tour", typeof(Tour) },
            {"event-ticket", typeof(EventTicket) }
        };

        public List<Offer> ConvertToOffers()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../YML.xml");

            foreach(XmlNode node in xDoc.DocumentElement.ChildNodes)
            {
                var XMLType = node.Attributes["type"].Value;

                Type type;
                if(!XML2ClassType.TryGetValue(XMLType, out type))
                {
                    throw new Exception($"{nameof(XML2ClassType)} Doesnt contain {XMLType} key");
                }
            }
            // Так а почему опер

            return new List<Offer>();
        }
    }
}
