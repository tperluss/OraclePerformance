using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    public class ReportRequest
    {
        public string ReportPath { get; set; }

        public string FilterExpressions { get; set; }
    }
}
