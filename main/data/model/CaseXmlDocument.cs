using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExecutePY
{
    public class CaseXmlDocument
    {
        public string Location { get; set; }
        public IEnumerable<XElement> Node { get; set; }

        public CaseXmlDocument(string location)
        {
            Location = location;
        }
    }
}
