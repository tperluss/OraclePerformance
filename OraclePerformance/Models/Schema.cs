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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:xml-analysis:rowset", IsNullable = false,ElementName ="rowset")]
    public partial class rowsetschema
    {

        private schema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2001/WB")]
        public schema schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/WB")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2001/WB", IsNullable = false)]
    public partial class schema
    {

        private schemaComplexType complexTypeField;

        private string targetNamespaceField;

        /// <remarks/>
        public schemaComplexType complexType
        {
            get
            {
                return this.complexTypeField;
            }
            set
            {
                this.complexTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetNamespace
        {
            get
            {
                return this.targetNamespaceField;
            }
            set
            {
                this.targetNamespaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/WB")]
    public partial class schemaComplexType
    {

        private schemaComplexTypeElement[] sequenceField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable = false)]
        public schemaComplexTypeElement[] sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2001/WB")]
    public partial class schemaComplexTypeElement
    {

        private string nameField;

        private string typeField;

        private byte minOccursField;

        private byte maxOccursField;

        private string type1Field;

        private string sqlFormulaField;

        private string displayFormulaField;

        private string aggregationRuleField;

        private string aggregationTypeField;

        private string tableHeadingField;

        private string columnHeadingField;

        private bool isDoubleColumnField;

        private string columnIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte minOccurs
        {
            get
            {
                return this.minOccursField;
            }
            set
            {
                this.minOccursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte maxOccurs
        {
            get
            {
                return this.maxOccursField;
            }
            set
            {
                this.maxOccursField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string type1
        {
            get
            {
                return this.type1Field;
            }
            set
            {
                this.type1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string sqlFormula
        {
            get
            {
                return this.sqlFormulaField;
            }
            set
            {
                this.sqlFormulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string displayFormula
        {
            get
            {
                return this.displayFormulaField;
            }
            set
            {
                this.displayFormulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string aggregationRule
        {
            get
            {
                return this.aggregationRuleField;
            }
            set
            {
                this.aggregationRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string aggregationType
        {
            get
            {
                return this.aggregationTypeField;
            }
            set
            {
                this.aggregationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string tableHeading
        {
            get
            {
                return this.tableHeadingField;
            }
            set
            {
                this.tableHeadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string columnHeading
        {
            get
            {
                return this.columnHeadingField;
            }
            set
            {
                this.columnHeadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public bool isDoubleColumn
        {
            get
            {
                return this.isDoubleColumnField;
            }
            set
            {
                this.isDoubleColumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:saw-sql")]
        public string columnID
        {
            get
            {
                return this.columnIDField;
            }
            set
            {
                this.columnIDField = value;
            }
        }
    }


}
