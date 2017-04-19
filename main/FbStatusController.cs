using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class FbCaseController
    {
        private MainBox mainBox;
        private FbCase fbCase;

        public FbCaseController(FbCase fbCase, MainBox mainBox)
        {
            this.fbCase = fbCase;
            this.mainBox = mainBox;
        }

        #region FbCase Properties
        public void SetStatus(string status)
        {
            fbCase.Status = status;
        }
        public string GetStatus()
        {
            return fbCase.Status;
        }
        public void SetID(string id)
        {
            fbCase.ID = id;
        }
        public string GetID()
        {
            return fbCase.ID;
        }
        public void SetTitle(string title)
        {
            fbCase.Title = title;
        }
        public string GetTitle()
        {
            return fbCase.Title;
        }
        public void SetPriority(string priority)
        {
            fbCase.Priority = priority;
        }
        public string GetPriority()
        {
            return fbCase.Priority;
        }
        public void SetDateOpened(string dateOpened)
        {
            fbCase.DateOpened = dateOpened.Replace("T", " ").Replace("Z", " ");
        }
        public string GetDateOpened()
        {
            return fbCase.DateOpened;
        }
        #endregion

        #region FbCase Methods

        public void AddList(List<FbCase> fbCases)
        {
            fbCases.Add(fbCase);
        }

        public void RemoveList(List<FbCase> fbCases)
        {
            fbCases.Clear();
        }
        #endregion
    }
}
