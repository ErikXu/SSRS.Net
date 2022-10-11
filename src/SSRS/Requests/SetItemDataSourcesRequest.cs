namespace SSRS.Requests
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class SetItemDataSourcesRequest
    {

        private SetItemDataSources setItemDataSourcesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public SetItemDataSources SetItemDataSources
        {
            get
            {
                return this.setItemDataSourcesField;
            }
            set
            {
                this.setItemDataSourcesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class SetItemDataSources
    {

        private string itemPathField;

        private SetItemDataSourcesDataSources dataSourcesField;

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

        /// <remarks/>
        public SetItemDataSourcesDataSources DataSources
        {
            get
            {
                return this.dataSourcesField;
            }
            set
            {
                this.dataSourcesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SetItemDataSourcesDataSources
    {

        private SetItemDataSourcesDataSourcesDataSource dataSourceField;

        /// <remarks/>
        public SetItemDataSourcesDataSourcesDataSource DataSource
        {
            get
            {
                return this.dataSourceField;
            }
            set
            {
                this.dataSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SetItemDataSourcesDataSourcesDataSource
    {

        private string nameField;

        private SetItemDataSourcesDataSourcesDataSourceDataSourceDefinition dataSourceDefinitionField;

        private object invalidDataSourceReferenceField;

        private SetItemDataSourcesDataSourcesDataSourceDataSourceReference dataSourceReferenceField;

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
        public SetItemDataSourcesDataSourcesDataSourceDataSourceDefinition DataSourceDefinition
        {
            get
            {
                return this.dataSourceDefinitionField;
            }
            set
            {
                this.dataSourceDefinitionField = value;
            }
        }

        /// <remarks/>
        public object InvalidDataSourceReference
        {
            get
            {
                return this.invalidDataSourceReferenceField;
            }
            set
            {
                this.invalidDataSourceReferenceField = value;
            }
        }

        /// <remarks/>
        public SetItemDataSourcesDataSourcesDataSourceDataSourceReference DataSourceReference
        {
            get
            {
                return this.dataSourceReferenceField;
            }
            set
            {
                this.dataSourceReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SetItemDataSourcesDataSourcesDataSourceDataSourceDefinition
    {

        private string extensionField;

        private string connectStringField;

        private string useOriginalConnectStringField;

        private string originalConnectStringExpressionBasedField;

        private string credentialRetrievalField;

        private string windowsCredentialsField;

        private string impersonateUserField;

        private string promptField;

        private string userNameField;

        private string passwordField;

        private string enabledField;

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        public string ConnectString
        {
            get
            {
                return this.connectStringField;
            }
            set
            {
                this.connectStringField = value;
            }
        }

        /// <remarks/>
        public string UseOriginalConnectString
        {
            get
            {
                return this.useOriginalConnectStringField;
            }
            set
            {
                this.useOriginalConnectStringField = value;
            }
        }

        /// <remarks/>
        public string OriginalConnectStringExpressionBased
        {
            get
            {
                return this.originalConnectStringExpressionBasedField;
            }
            set
            {
                this.originalConnectStringExpressionBasedField = value;
            }
        }

        /// <remarks/>
        public string CredentialRetrieval
        {
            get
            {
                return this.credentialRetrievalField;
            }
            set
            {
                this.credentialRetrievalField = value;
            }
        }

        /// <remarks/>
        public string WindowsCredentials
        {
            get
            {
                return this.windowsCredentialsField;
            }
            set
            {
                this.windowsCredentialsField = value;
            }
        }

        /// <remarks/>
        public string ImpersonateUser
        {
            get
            {
                return this.impersonateUserField;
            }
            set
            {
                this.impersonateUserField = value;
            }
        }

        /// <remarks/>
        public string Prompt
        {
            get
            {
                return this.promptField;
            }
            set
            {
                this.promptField = value;
            }
        }

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public string Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class SetItemDataSourcesDataSourcesDataSourceDataSourceReference
    {

        private string referenceField;

        /// <remarks/>
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }
}
