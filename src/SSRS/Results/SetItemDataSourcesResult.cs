namespace SSRS.Results
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class SetItemDataSourcesResult
    {

        private object setItemDataSourcesResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public object SetItemDataSourcesResponse
        {
            get
            {
                return this.setItemDataSourcesResponseField;
            }
            set
            {
                this.setItemDataSourcesResponseField = value;
            }
        }
    }


}
