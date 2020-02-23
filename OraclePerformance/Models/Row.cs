using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    public class Row
    {
        public Row()
        {
            Columns = new Dictionary<string, object>();
        }

        public Dictionary<string, object> Columns { get; set; }
    }
}
