using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class ListManager
    {
        
        private static List<List<string>> typeList = new List<List<string>>();

        private static List<string> activeList = new List<string>();
        private static List<string> inProgressList = new List<string>();
        private static List<string> longTermList = new List<string>(); 
        private static List<string> feedbackList = new List<string>();
        private static List<string> onHoldList = new List<string>();



        public static void Check(string sStatus, string ixBug, string sTitle, string ixPriority, string dtOpened)
        {

            if (sStatus.Contains("Active"))
                Add(sStatus, ixBug, sTitle, ixPriority, dtOpened, activeList);
            if (sStatus == "In Progress")
                Add(sStatus, ixBug, sTitle, ixPriority, dtOpened, inProgressList);
            if (sStatus == "Long-Term")
                Add(sStatus, ixBug, sTitle, ixPriority, dtOpened, longTermList);
            if (sStatus.Contains("Feedback Required"))
                Add(sStatus, ixBug, sTitle, ixPriority, dtOpened, feedbackList);
            if (sStatus == "On Hold")
                Add(sStatus, ixBug, sTitle, ixPriority, dtOpened, onHoldList);
        }

        private static void Add(string sStatus, string ixBug, string sTitle, string ixPriority, string dtOpened, List<string> fogList)
        {
            fogList.Add(sStatus);
            fogList.Add(ixBug);
            fogList.Add(sTitle);
            fogList.Add(ixPriority);
            fogList.Add(dtOpened.Replace("T", " ").Replace("Z", " "));

            typeList.Add(fogList);
        }

        public static List<List<string>> GetTypeList()
        {
            return typeList;
        }

        public static List<string> GetActiveList()
        {
            return activeList;
        }
        public static List<string> GetInProgressList()
        {
            return inProgressList;
        }
        public static List<string> GetLongTermList()
        {
            return longTermList;
        }
        public static List<string> GetFeedbackList()
        {
            return feedbackList;
        }
        public static List<string> GetOnHoldList()
        {
            return onHoldList;
        }

        public static void RemoveList()
        {
            typeList.Clear();
            activeList.Clear();
            inProgressList.Clear();
            longTermList.Clear();
            feedbackList.Clear();
            onHoldList.Clear();
        }

    }
}
