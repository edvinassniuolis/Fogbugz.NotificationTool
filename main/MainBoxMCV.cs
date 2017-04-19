using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class MainBoxMCV
    {
        public static void ParseCases(FbCase fbCase, MainBox mainBox)
        {
            FbCaseController fbCaseController = new FbCaseController(fbCase, mainBox);

            fbCaseController.SetStatus(fbCase.Status);
            fbCaseController.SetID(fbCase.ID);
            fbCaseController.SetPriority(fbCase.Priority);
            fbCaseController.SetTitle(fbCase.Title);
            fbCaseController.SetDateOpened(fbCase.DateOpened);
        }
    }
}
