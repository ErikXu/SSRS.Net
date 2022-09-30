namespace SSRS.Results
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false, ElementName = "Envelope")]
    public partial class XmlResult<T>
    {
        private EnvelopeHeader headerField;

        private T bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public T Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeHeader
    {

        private ServerInfoHeader serverInfoHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
        public ServerInfoHeader ServerInfoHeader
        {
            get
            {
                return this.serverInfoHeaderField;
            }
            set
            {
                this.serverInfoHeaderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer", IsNullable = false)]
    public partial class ServerInfoHeader
    {

        private string reportServerVersionNumberField;

        private string reportServerEditionField;

        private string reportServerVersionField;

        private System.DateTime reportServerDateTimeField;

        private ServerInfoHeaderReportServerTimeZoneInfo reportServerTimeZoneInfoField;

        /// <remarks/>
        public string ReportServerVersionNumber
        {
            get
            {
                return this.reportServerVersionNumberField;
            }
            set
            {
                this.reportServerVersionNumberField = value;
            }
        }

        /// <remarks/>
        public string ReportServerEdition
        {
            get
            {
                return this.reportServerEditionField;
            }
            set
            {
                this.reportServerEditionField = value;
            }
        }

        /// <remarks/>
        public string ReportServerVersion
        {
            get
            {
                return this.reportServerVersionField;
            }
            set
            {
                this.reportServerVersionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReportServerDateTime
        {
            get
            {
                return this.reportServerDateTimeField;
            }
            set
            {
                this.reportServerDateTimeField = value;
            }
        }

        /// <remarks/>
        public ServerInfoHeaderReportServerTimeZoneInfo ReportServerTimeZoneInfo
        {
            get
            {
                return this.reportServerTimeZoneInfoField;
            }
            set
            {
                this.reportServerTimeZoneInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ServerInfoHeaderReportServerTimeZoneInfo
    {

        private short biasField;

        private byte standardBiasField;

        private ServerInfoHeaderReportServerTimeZoneInfoStandardDate standardDateField;

        private sbyte daylightBiasField;

        private ServerInfoHeaderReportServerTimeZoneInfoDaylightDate daylightDateField;

        /// <remarks/>
        public short Bias
        {
            get
            {
                return this.biasField;
            }
            set
            {
                this.biasField = value;
            }
        }

        /// <remarks/>
        public byte StandardBias
        {
            get
            {
                return this.standardBiasField;
            }
            set
            {
                this.standardBiasField = value;
            }
        }

        /// <remarks/>
        public ServerInfoHeaderReportServerTimeZoneInfoStandardDate StandardDate
        {
            get
            {
                return this.standardDateField;
            }
            set
            {
                this.standardDateField = value;
            }
        }

        /// <remarks/>
        public sbyte DaylightBias
        {
            get
            {
                return this.daylightBiasField;
            }
            set
            {
                this.daylightBiasField = value;
            }
        }

        /// <remarks/>
        public ServerInfoHeaderReportServerTimeZoneInfoDaylightDate DaylightDate
        {
            get
            {
                return this.daylightDateField;
            }
            set
            {
                this.daylightDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ServerInfoHeaderReportServerTimeZoneInfoStandardDate
    {

        private byte yearField;

        private byte monthField;

        private byte dayOfWeekField;

        private byte dayField;

        private byte hourField;

        private byte minuteField;

        private byte secondField;

        private byte millisecondsField;

        /// <remarks/>
        public byte year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public byte month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        public byte dayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }

        /// <remarks/>
        public byte day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        public byte hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        public byte minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        public byte second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }

        /// <remarks/>
        public byte milliseconds
        {
            get
            {
                return this.millisecondsField;
            }
            set
            {
                this.millisecondsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2010/03/01/ReportServer")]
    public partial class ServerInfoHeaderReportServerTimeZoneInfoDaylightDate
    {

        private byte yearField;

        private byte monthField;

        private byte dayOfWeekField;

        private byte dayField;

        private byte hourField;

        private byte minuteField;

        private byte secondField;

        private byte millisecondsField;

        /// <remarks/>
        public byte year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public byte month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        /// <remarks/>
        public byte dayOfWeek
        {
            get
            {
                return this.dayOfWeekField;
            }
            set
            {
                this.dayOfWeekField = value;
            }
        }

        /// <remarks/>
        public byte day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        public byte hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }

        /// <remarks/>
        public byte minute
        {
            get
            {
                return this.minuteField;
            }
            set
            {
                this.minuteField = value;
            }
        }

        /// <remarks/>
        public byte second
        {
            get
            {
                return this.secondField;
            }
            set
            {
                this.secondField = value;
            }
        }

        /// <remarks/>
        public byte milliseconds
        {
            get
            {
                return this.millisecondsField;
            }
            set
            {
                this.millisecondsField = value;
            }
        }
    }
}
