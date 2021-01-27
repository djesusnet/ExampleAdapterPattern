using ExampleAdapterPattern.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace ExampleAdapterPattern
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();
            var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMobiles", true);
            return doc;
        }
    }
}
