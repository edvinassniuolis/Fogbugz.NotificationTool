using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class MainMVC
    {
        public static void ParseXml(CaseXmlDocument xDocument, MainView mainBoxView)
        {
            CaseController xmlDocumentController = new CaseController(xDocument, mainBoxView);

            xmlDocumentController.SetLocation(xDocument.Location);
            xmlDocumentController.LoadXml();
            xmlDocumentController.ParseXml();
            xmlDocumentController.CreateCases();
            xmlDocumentController.CheckCases();

            xmlDocumentController.SetViewCases();

        }
    }
}
