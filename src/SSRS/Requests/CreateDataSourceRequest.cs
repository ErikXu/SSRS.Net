namespace SSRS.Requests
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class CreateDataSourceRequest
    {

        private CreateDataSource createDataSourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public CreateDataSource CreateDataSource
        {
            get
            {
                return this.createDataSourceField;
            }
            set
            {
                this.createDataSourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class CreateDataSource
    {

        private string dataSourceField;

        private string parentField;

        private bool overwriteField;

        private CreateDataSourceDefinition definitionField;

        /// <remarks/>
        public string DataSource
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

        /// <remarks/>
        public string Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public bool Overwrite
        {
            get
            {
                return this.overwriteField;
            }
            set
            {
                this.overwriteField = value;
            }
        }

        /// <remarks/>
        public CreateDataSourceDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class CreateDataSourceDefinition
    {

        private string extensionField;

        private string connectStringField;

        private bool useOriginalConnectStringField;

        private bool originalConnectStringExpressionBasedField;

        private string credentialRetrievalField;

        private bool windowsCredentialsField;

        private bool impersonateUserField;

        private string userNameField;

        private string passwordField;

        private bool enabledField;

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
        public bool UseOriginalConnectString
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
        public bool OriginalConnectStringExpressionBased
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
        public bool WindowsCredentials
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
        public bool ImpersonateUser
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
        public bool Enabled
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


}
