namespace SSRS.Requests
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class IsSSLRequiredRequest
    {

        private object isSSLRequiredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public object IsSSLRequired
        {
            get
            {
                return this.isSSLRequiredField;
            }
            set
            {
                this.isSSLRequiredField = value;
            }
        }
    }
}
