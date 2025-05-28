namespace OinGenerator.Models
{
    using System.Xml;
    using System.Xml.Serialization;


    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    [XmlRoot("StanForD2010Envelope", Namespace = "urn:skogforsk:stanford2010", IsNullable = false)]
    public partial class StanForD2010EnvelopeType
    {
        private StanForD2010EnvelopeHeaderType stanForD2010EnvelopeHeaderField;
        private StanForD2010MessageType[] stanForD2010MessageField;
        private ExtensionType extensionField;
        private MessageCategoryType messageTypeField;
        private string versionField;
        private DateTime versionDateField;
        private string schemaLocationField;

        public StanForD2010EnvelopeType() { }

        public StanForD2010EnvelopeHeaderType StanForD2010EnvelopeHeader
        {
            get { return stanForD2010EnvelopeHeaderField; }
            set { stanForD2010EnvelopeHeaderField = value; }
        }

        [XmlElement("StanForD2010Message")]
        public StanForD2010MessageType[] StanForD2010Message
        {
            get { return stanForD2010MessageField; }
            set { stanForD2010MessageField = value; }
        }

        public ExtensionType Extension
        {
            get { return extensionField; }
            set { extensionField = value; }
        }

        [XmlAttribute()]
        public MessageCategoryType messageType
        {
            get { return messageTypeField; }
            set { messageTypeField = value; }
        }

        [XmlAttribute()]
        public string version
        {
            get { return versionField; }
            set { versionField = value; }
        }

        [XmlAttribute(DataType = "date")]
        public DateTime versionDate
        {
            get { return versionDateField; }
            set { versionDateField = value; }
        }

        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation
        {
            get { return schemaLocationField; }
            set { schemaLocationField = value; }
        }

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[] {
            new XmlQualifiedName("xsi", "http://www.w3.org/2001/XMLSchema-instance"),
            new XmlQualifiedName("", "urn:skogforsk:stanford2010")
        });
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class StanForD2010EnvelopeHeaderType
    {
        private ContactInformationType businessSenderField;
        private ContactInformationType businessReceiverField;

        public ContactInformationType BusinessSender
        {
            get { return businessSenderField; }
            set { businessSenderField = value; }
        }

        public ContactInformationType BusinessReceiver
        {
            get { return businessReceiverField; }
            set { businessReceiverField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class TransmissionInfoType
    {

        private UserIDType transmissionIDField;

        private DateTime transmissionTimeField;

        private string transmissionSenderField;

        private string transmissionReceiverField;

        /// <remarks/>
        public UserIDType TransmissionID
        {
            get
            {
                return transmissionIDField;
            }
            set
            {
                transmissionIDField = value;
            }
        }

        /// <remarks/>
        public DateTime TransmissionTime
        {
            get
            {
                return transmissionTimeField;
            }
            set
            {
                transmissionTimeField = value;
            }
        }

        /// <remarks/>
        public string TransmissionSender
        {
            get
            {
                return transmissionSenderField;
            }
            set
            {
                transmissionSenderField = value;
            }
        }

        /// <remarks/>
        public string TransmissionReceiver
        {
            get
            {
                return transmissionReceiverField;
            }
            set
            {
                transmissionReceiverField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class UserIDType
    {

        private AgencyType agencyField;

        private bool agencyFieldSpecified;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public AgencyType agency
        {
            get
            {
                return agencyField;
            }
            set
            {
                agencyField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool agencySpecified
        {
            get
            {
                return agencyFieldSpecified;
            }
            set
            {
                agencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum AgencyType
    {

        /// <remarks/>
        Buyer,

        /// <remarks/>
        ForestOwner,

        /// <remarks/>
        LoggingContractor,

        /// <remarks/>
        LoggingOrganisation,

        /// <remarks/>
        MachineOwner,

        /// <remarks/>
        Other,

        /// <remarks/>
        Seller,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ExtensionType
    {
        // Define properties for ExtensionType if needed
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum ExtensionActionType
    {

        /// <remarks/>
        Copy,

        /// <remarks/>
        Ignore,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class AttachmentType
    {

        private object itemField;

        private string attachmentNameField;

        private string schemaNameField;

        private SignatureType[] signatureField;

        /// <remarks/>
        [XmlElement("EmbeddedAttachment", typeof(EmbeddedType))]
        [XmlElement("ExternalAttachment", typeof(ExternalDocumentType))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        public string AttachmentName
        {
            get
            {
                return attachmentNameField;
            }
            set
            {
                attachmentNameField = value;
            }
        }

        /// <remarks/>
        public string SchemaName
        {
            get
            {
                return schemaNameField;
            }
            set
            {
                schemaNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement("Signature")]
        public SignatureType[] Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class EmbeddedType
    {

        private EmbeddedTypeEncodingMethod encodingMethodField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public EmbeddedTypeEncodingMethod encodingMethod
        {
            get
            {
                return encodingMethodField;
            }
            set
            {
                encodingMethodField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "urn:skogforsk:stanford2010")]
    public enum EmbeddedTypeEncodingMethod
    {

        /// <remarks/>
        Base64,

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ExternalDocumentType
    {

        private string documentLocationField;

        private CompressionType compressionField;

        /// <remarks/>
        [XmlElement(IsNullable = true)]
        public string DocumentLocation
        {
            get
            {
                return documentLocationField;
            }
            set
            {
                documentLocationField = value;
            }
        }

        /// <remarks/>
        public CompressionType Compression
        {
            get
            {
                return compressionField;
            }
            set
            {
                compressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class CompressionType
    {

        private CompressionCategoryType compressionCategoryField;

        private string compressionSoftwareField;

        /// <remarks/>
        public CompressionCategoryType CompressionCategory
        {
            get
            {
                return compressionCategoryField;
            }
            set
            {
                compressionCategoryField = value;
            }
        }

        /// <remarks/>
        public string CompressionSoftware
        {
            get
            {
                return compressionSoftwareField;
            }
            set
            {
                compressionSoftwareField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum CompressionCategoryType
    {

        /// <remarks/>
        [XmlEnum("ZIP/DEFLATE")]
        ZIPDEFLATE,

        /// <remarks/>
        [XmlEnum("Not defined")]
        Notdefined,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SignatureType
    {

        private XmlElement anyField;

        private SignatureCategoryType signatureCategoryField;

        /// <remarks/>
        [XmlAnyElement()]
        public XmlElement Any
        {
            get
            {
                return anyField;
            }
            set
            {
                anyField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public SignatureCategoryType signatureCategory
        {
            get
            {
                return signatureCategoryField;
            }
            set
            {
                signatureCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum SignatureCategoryType
    {

        /// <remarks/>
        [XmlEnum("XML Signature")]
        XMLSignature,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class MessageType
    {
        private string itemField;
        private EmbeddedType embeddedDocumentField;

        [XmlElement("Item")]
        public string Item
        {
            get { return itemField; }
            set { itemField = value; }
        }

        [XmlElement("EmbeddedDocument")]
        public EmbeddedType EmbeddedDocument
        {
            get { return embeddedDocumentField; }
            set { embeddedDocumentField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class StanForD2010MessageType
    {
        private MessageCategoryType messageCategoryField;
        private MessageType messageDocumentField;

        [XmlAttribute()]
        public MessageCategoryType messageCategory
        {
            get { return messageCategoryField; }
            set { messageCategoryField = value; }
        }

        public MessageType MessageDocument
        {
            get { return messageDocumentField; }
            set { messageDocumentField = value; }
        }
    }

    /// <remarks/>
    public enum MessageCategoryType
    {
        env,
        oin,
        spi,
        pin
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class AddressType
    {

        private string streetField;

        private string cityField;

        private string provinceField;

        private string countryField;

        /// <remarks/>
        public string Street
        {
            get
            {
                return streetField;
            }
            set
            {
                streetField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return cityField;
            }
            set
            {
                cityField = value;
            }
        }

        /// <remarks/>
        public string Province
        {
            get
            {
                return provinceField;
            }
            set
            {
                provinceField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return countryField;
            }
            set
            {
                countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ContactInformationType
    {
        private string businessNameField;

        [XmlElement("BusinessName")]
        public string BusinessName
        {
            get { return businessNameField; }
            set { businessNameField = value; }
        }
    }
}
