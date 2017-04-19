using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class FbCase
    {
        public string Status { get; set; }
        public string ID { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string DateOpened { get; set; }

        public FbCase(string status, string id, string title, string priority, string dateOpened)
        {
            Status = status;
            ID = id;
            Title = title;
            Priority = priority;
            DateOpened = dateOpened;
        }
    }
}
