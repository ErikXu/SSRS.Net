using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRS.Results
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class GetSystemPropertiesResult
    {

        private GetSystemPropertiesResponse getSystemPropertiesResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public GetSystemPropertiesResponse GetSystemPropertiesResponse
        {
            get
            {
                return this.getSystemPropertiesResponseField;
            }
            set
            {
                this.getSystemPropertiesResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class GetSystemPropertiesResponse
    {

        private GetSystemPropertiesResponseValues valuesField;

        /// <remarks/>
        public GetSystemPropertiesResponseValues Values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class GetSystemPropertiesResponseValues
    {

        private GetSystemPropertiesResponseValuesProperty propertyField;

        /// <remarks/>
        public GetSystemPropertiesResponseValuesProperty Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class GetSystemPropertiesResponseValuesProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string Name
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
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
