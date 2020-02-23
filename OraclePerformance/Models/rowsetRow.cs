using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-analysis:rowset")]
    public partial class rowsetRow
    {

        private string column0Field;

        private System.DateTime column1Field;

        private string column2Field;

        private System.DateTime column3Field;

        private string column4Field;

        private string column5Field;

        /// <remarks/>
        public string Column0
        {
            get
            {
                return this.column0Field;
            }
            set
            {
                this.column0Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Column1
        {
            get
            {
                return this.column1Field;
            }
            set
            {
                this.column1Field = value;
            }
        }

        /// <remarks/>
        public string Column2
        {
            get
            {
                return this.column2Field;
            }
            set
            {
                this.column2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Column3
        {
            get
            {
                return this.column3Field;
            }
            set
            {
                this.column3Field = value;
            }
        }

        /// <remarks/>
        public string Column4
        {
            get
            {
                return this.column4Field;
            }
            set
            {
                this.column4Field = value;
            }
        }

        /// <remarks/>
        public string Column5
        {
            get
            {
                return this.column5Field;
            }
            set
            {
                this.column5Field = value;
            }
        }
    }
}
