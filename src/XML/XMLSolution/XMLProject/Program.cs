using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XMLProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement withoutImageFile;
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "con-image.xml");
            withoutImageFile = XElement.Load(directory);

            //IEnumerable<XElement> pricesByPartNos = from item in withoutImageFile.Descendants("p")
            //                                        //where (int)item.Element("Quantity") * (decimal)item.Element("USPrice") > 100
            //                                        //orderby (string)item.Element("PartNumber")
            //                                        select item;

            XmlDocument bodyDoc = new XmlDocument();
            bodyDoc.LoadXml(withoutImageFile.ToString());
            XmlNodeList images = bodyDoc.SelectNodes("//img");
            foreach (XmlNode image in images)
            {
                string imgAltAttribute = image.Attributes["alt"].Value;
                string imgHeightAttribute = image.Attributes["height"].Value;
                string imgWidthAttribute = image.Attributes["width"].Value;
                string imgImageIdAttribute = image.Attributes["imageid"].Value;
                string imgTitleAttribute = image.Attributes["title"].Value;
                string imgValue = image.Value;
            }
        }
    }
}
