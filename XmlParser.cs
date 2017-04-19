using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExecutePY
{
    public class XmlParser
    {
        public static void Parse(string filename)
        {
            var doc = XDocument.Load(filename);

            var ixBug = doc.Descendants("ixBug");
            var sTitle = doc.Descendants("sTitle");
            var ixPriority = doc.Descendants("ixPriority");
            var dtOpened = doc.Descendants("dtOpened");
            var sStatus = doc.Descendants("sStatus");


            for (int i = 0; i < ixBug.Count(); i++)
                    ListManager.Check(sStatus.ElementAt(i).Value, ixBug.ElementAt(i).Value, sTitle.ElementAt(i).Value, ixPriority.ElementAt(i).Value, dtOpened.ElementAt(i).Value);
        }

    }
}
