namespace SSRS.Requests
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class GetItemTypeRequest
    {

        private GetItemType getItemTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public GetItemType GetItemType
        {
            get
            {
                return this.getItemTypeField;
            }
            set
            {
                this.getItemTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class GetItemType
    {

        private string itemPathField;

        /// <remarks/>
        public string ItemPath
        {
            get
            {
                return this.itemPathField;
            }
            set
            {
                this.itemPathField = value;
            }
        }
    }
}
