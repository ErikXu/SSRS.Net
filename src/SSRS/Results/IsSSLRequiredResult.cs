namespace SSRS.Results
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class IsSSLRequiredResult
    {

        private IsSSLRequiredResponse isSSLRequiredResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public IsSSLRequiredResponse IsSSLRequiredResponse
        {
            get
            {
                return this.isSSLRequiredResponseField;
            }
            set
            {
                this.isSSLRequiredResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class IsSSLRequiredResponse
    {

        private bool isSSLRequiredResultField;

        /// <remarks/>
        public bool IsSSLRequiredResult
        {
            get
            {
                return this.isSSLRequiredResultField;
            }
            set
            {
                this.isSSLRequiredResultField = value;
            }
        }
    }
}
