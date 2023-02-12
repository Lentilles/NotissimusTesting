using NotissimusTesting.DAL.Models.Offers;
using System.Xml;
using System.Text;

namespace NotissimusTesting.DAL.Converter
{
    public class xml2classes
    {
        public static List<Offer> ReadXml(string path)
        {
            List<Offer> result = new List<Offer>();
            XmlDocument xDoc = new XmlDocument();

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var context = new XmlParserContext(null, null, null, XmlSpace.None);
            context.Encoding = Encoding.GetEncoding(1252);
            var settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;

            using(var reader = XmlReader.Create(path, settings, context))
            {
                xDoc.Load(reader);
            }

            var OfferNodes = xDoc.GetElementsByTagName("offer");

            foreach(XmlNode node in OfferNodes)
            {
                int offerId;
                if(int.TryParse(node.Attributes.GetNamedItem("id").Value, out offerId)){
                    Offer offer = new Offer() { Id = offerId };
                    foreach (XmlNode childNode in node)
                    {
                        offer.Elements.Add(new OfferElement()
                        {
                            Offer = offer,
                            ElementName = childNode.Name,
                            Value = childNode.InnerText,
                        });
                    }
                    result.Add(offer);
                }
            }
            return result;
        }
    }
}
