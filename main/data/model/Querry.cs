using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutePY
{
    public class Querry
    {
        public string QuerryColumn { get; set; }

        public Querry(string querryColumn)
        {
            QuerryColumn = querryColumn;
        }
    }
}
