using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclePerformance.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:xml-analysis:rowset")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-analysis:rowset", IsNullable = false)]
    public partial class rowset
    {

        private rowsetRow rowField;

        /// <remarks/>
        public rowsetRow Row
        {
            get
            {
                return this.rowField;
            }
            set
            {
                this.rowField = value;
            }
        }
    }
}
