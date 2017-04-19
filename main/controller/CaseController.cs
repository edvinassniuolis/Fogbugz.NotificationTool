#undef DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ExecutePY
{
    public class CaseController
    {

        private MainView mainBoxView;
        private CaseXmlDocument xDocument;

        private IEnumerable<XElement> sStatus;
        private IEnumerable<XElement> ixBug;
        private IEnumerable<XElement> sTitle;
        private IEnumerable<XElement> ixPriority;
        private IEnumerable<XElement> dtOpened;

        private XDocument doc;

        private List<FbCase> fbCases = new List<FbCase>();

        private List<FbCase> activeCases = new List<FbCase>();
        private List<FbCase> inProgressCases = new List<FbCase>();
        private List<FbCase> longTermCases = new List<FbCase>();
        private List<FbCase> feedbackCases = new List<FbCase>();
        private List<FbCase> onHoldCases = new List<FbCase>();

        public CaseController(CaseXmlDocument xDocument, MainView mainBoxView)
        {
            this.xDocument = xDocument;
            this.mainBoxView = mainBoxView;
        }

        #region XDocument properties
        public void SetLocation(string location)
        {
            xDocument.Location = location;
        }
        public string GetLocation()
        {
            return xDocument.Location;
        }
        public void SetNode(IEnumerable<XElement> node)
        {
            xDocument.Node = node;
        }
        public IEnumerable<XElement> GetNode()
        {
            return xDocument.Node;
        }
        #endregion

        #region XDocument methods
        public void ExpandXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load(GetLocation());
            XmlWriterSettings settings = new XmlWriterSettings();
            
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(GetLocation(), settings))
            {
                document.WriteTo(writer);
            }
        }

        public void LoadXml()
        {
            doc = XDocument.Load(GetLocation());
        }

        public void ParseXml()
        {
            sStatus = doc.Descendants("sStatus");
            ixBug = doc.Descendants("ixBug");
            sTitle = doc.Descendants("sTitle");
            ixPriority = doc.Descendants("ixPriority");
            dtOpened = doc.Descendants("dtOpened"); 
        }

        public void CreateCases()
        {
            for (int i = 0; i < sStatus.Count(); i++)
            {
                fbCases.Add( new FbCase(
                        sStatus.ElementAt(i).Value,
                        ixBug.ElementAt(i).Value,
                        sTitle.ElementAt(i).Value,
                        ixPriority.ElementAt(i).Value,
                        dtOpened.ElementAt(i).Value.Replace("T", " ").Replace("Z", " ")));
            } 
        }

        public void SetViewCases()
        {
            mainBoxView.SetFbCases(activeCases);
        }

        public void CheckCases()
        {
            foreach (var fbCase in fbCases)
            {
                if (fbCase.Status.Contains("Active"))
                    activeCases.Add(fbCase);
                else if (fbCase.Status.Contains("In Progress"))
                    inProgressCases.Add(fbCase);
                else if (fbCase.Status.Contains("Long-Term"))
                    longTermCases.Add(fbCase);
                else if (fbCase.Status.Contains("Feedback Required"))
                    feedbackCases.Add(fbCase);
                else if (fbCase.Status.Contains("On Hold"))
                    onHoldCases.Add(fbCase);
            }
        }
        #endregion
    }
}
