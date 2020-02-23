using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    public class ReportSchema
    {
        public string ReportPath { get; set; }

        public List<ColumnSchema> Columns { get; set; }
    }

    public class ColumnSchema
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public byte MinOccurs { get; set; }

        public byte MaxOccurs { get; set; }

        public string SqlType { get; set; }

        public string TableHeading { get; set; }

        public string ColumnHeading { get; set; }

        public bool IsDoubleColumn { get; set; }

        public string ColumnId { get; set; }
    }

}
