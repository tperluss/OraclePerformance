using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    public class ReportRows
    {
        public ReportRows()
        {
            Rows = new List<Row>();
        }

        public List<Row> Rows { get; set; }
    }
}
