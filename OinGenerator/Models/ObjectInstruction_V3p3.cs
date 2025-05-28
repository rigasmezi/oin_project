namespace OinGenerator.Models
{
    using System.Xml;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    [XmlRoot("ObjectInstruction", Namespace = "urn:skogforsk:stanford2010", IsNullable = false)]
    public partial class ObjectInstructionType
    {

        private MessageHeaderType objectInstructionHeaderField;

        private ObjectDefinitionObjectInstructionType objectDefinitionField;

        private DiameterSectionDefinitionObjectInstructionType[] diameterSectionDefinitionField;

        private ExtensionType extensionField;

        private MessageCategoryType messageTypeField;

        private AreaUnitType areaUnitField;

        private DiameterUnitType diameterUnitField;

        private LengthUnitType lengthUnitField;

        private VolumeUnitType volumeUnitField;

        private WeightUnitType weightUnitField;

        private string versionField;

        private DateTime versionDateField;
        private string schemaLocationField;

        public ObjectInstructionType()
        {
            messageTypeField = MessageCategoryType.oin;
        }

        /// <remarks/>
        public MessageHeaderType ObjectInstructionHeader
        {
            get
            {
                return objectInstructionHeaderField;
            }
            set
            {
                objectInstructionHeaderField = value;
            }
        }

        /// <remarks/>
        public ObjectDefinitionObjectInstructionType ObjectDefinition
        {
            get
            {
                return objectDefinitionField;
            }
            set
            {
                objectDefinitionField = value;
            }
        }

        /// <remarks/>
        [XmlElement("DiameterSectionDefinition")]
        public DiameterSectionDefinitionObjectInstructionType[] DiameterSectionDefinition
        {
            get
            {
                return diameterSectionDefinitionField;
            }
            set
            {
                diameterSectionDefinitionField = value;
            }
        }

        /// <remarks/>
        public ExtensionType Extension
        {
            get
            {
                return extensionField;
            }
            set
            {
                extensionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public MessageCategoryType messageType
        {
            get
            {
                return messageTypeField;
            }
            set
            {
                messageTypeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public AreaUnitType areaUnit
        {
            get
            {
                return areaUnitField;
            }
            set
            {
                areaUnitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DiameterUnitType diameterUnit
        {
            get
            {
                return diameterUnitField;
            }
            set
            {
                diameterUnitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public LengthUnitType lengthUnit
        {
            get
            {
                return lengthUnitField;
            }
            set
            {
                lengthUnitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public VolumeUnitType volumeUnit
        {
            get
            {
                return volumeUnitField;
            }
            set
            {
                volumeUnitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public WeightUnitType weightUnit
        {
            get
            {
                return weightUnitField;
            }
            set
            {
                weightUnitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string version
        {
            get
            {
                return versionField;
            }
            set
            {
                versionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(DataType = "date")]
        public DateTime versionDate
        {
            get
            {
                return versionDateField;
            }
            set
            {
                versionDateField = value;
            }
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
    [XmlInclude(typeof(DiameterSectionDefinitionObjectInstructionType))]
    [XmlInclude(typeof(DiameterSectionDefinitionMachineType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterSectionDefinitionType
    {

        private UserIDType diameterSectionUserIDField;

        private string diameterSectionNameField;

        private string minimumDiameterField;

        private string minimumLengthField;

        private DiameterSectionUsageType diameterSectionUsageField;

        private bool diameterSectionUsageFieldSpecified;

        /// <remarks/>
        public UserIDType DiameterSectionUserID
        {
            get
            {
                return diameterSectionUserIDField;
            }
            set
            {
                diameterSectionUserIDField = value;
            }
        }

        /// <remarks/>
        public string DiameterSectionName
        {
            get
            {
                return diameterSectionNameField;
            }
            set
            {
                diameterSectionNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string MinimumDiameter
        {
            get
            {
                return minimumDiameterField;
            }
            set
            {
                minimumDiameterField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string MinimumLength
        {
            get
            {
                return minimumLengthField;
            }
            set
            {
                minimumLengthField = value;
            }
        }

        /// <remarks/>
        public DiameterSectionUsageType DiameterSectionUsage
        {
            get
            {
                return diameterSectionUsageField;
            }
            set
            {
                diameterSectionUsageField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool DiameterSectionUsageSpecified
        {
            get
            {
                return diameterSectionUsageFieldSpecified;
            }
            set
            {
                diameterSectionUsageFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum DiameterSectionUsageType
    {

        /// <remarks/>
        Buyer,

        /// <remarks/>
        Commercial,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterSectionDefinitionObjectInstructionType : DiameterSectionDefinitionType
    {

        private UserIDType speciesGroupUserIDField;

        /// <remarks/>
        public UserIDType SpeciesGroupUserID
        {
            get
            {
                return speciesGroupUserIDField;
            }
            set
            {
                speciesGroupUserIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterSectionDefinitionMachineType : DiameterSectionDefinitionType
    {

        private string diameterSectionKeyField;

        private string speciesGroupKeyField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string DiameterSectionKey
        {
            get
            {
                return diameterSectionKeyField;
            }
            set
            {
                diameterSectionKeyField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string SpeciesGroupKey
        {
            get
            {
                return speciesGroupKeyField;
            }
            set
            {
                speciesGroupKeyField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(SubObjectDefinitionObjectInstructionType))]
    [XmlInclude(typeof(SubObjectDefinitionMachineType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SubObjectDefinitionType
    {

        private UserIDType subObjectUserIDField;

        private string subObjectNameField;

        private decimal subObjectAreaField;

        private bool subObjectAreaFieldSpecified;

        private LoggingFormType loggingFormField;

        private RealEstateIDObjectType realEstateIDSubObjectField;

        private ExtensionType extensionField;

        /// <remarks/>
        public UserIDType SubObjectUserID
        {
            get
            {
                return subObjectUserIDField;
            }
            set
            {
                subObjectUserIDField = value;
            }
        }

        /// <remarks/>
        public string SubObjectName
        {
            get
            {
                return subObjectNameField;
            }
            set
            {
                subObjectNameField = value;
            }
        }

        /// <remarks/>
        public decimal SubObjectArea
        {
            get
            {
                return subObjectAreaField;
            }
            set
            {
                subObjectAreaField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool SubObjectAreaSpecified
        {
            get
            {
                return subObjectAreaFieldSpecified;
            }
            set
            {
                subObjectAreaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LoggingFormType LoggingForm
        {
            get
            {
                return loggingFormField;
            }
            set
            {
                loggingFormField = value;
            }
        }

        /// <remarks/>
        public RealEstateIDObjectType RealEstateIDSubObject
        {
            get
            {
                return realEstateIDSubObjectField;
            }
            set
            {
                realEstateIDSubObjectField = value;
            }
        }

        /// <remarks/>
        public ExtensionType Extension
        {
            get
            {
                return extensionField;
            }
            set
            {
                extensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LoggingFormType
    {

        private string loggingFormCodeField;

        private string loggingFormDescriptionField;

        private AgencyType agencyField;

        private bool agencyFieldSpecified;

        /// <remarks/>
        public string LoggingFormCode
        {
            get
            {
                return loggingFormCodeField;
            }
            set
            {
                loggingFormCodeField = value;
            }
        }

        /// <remarks/>
        public string LoggingFormDescription
        {
            get
            {
                return loggingFormDescriptionField;
            }
            set
            {
                loggingFormDescriptionField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class RealEstateIDObjectType
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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SubObjectDefinitionObjectInstructionType : SubObjectDefinitionType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SubObjectDefinitionMachineType : SubObjectDefinitionType
    {

        private string subObjectKeyField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string SubObjectKey
        {
            get
            {
                return subObjectKeyField;
            }
            set
            {
                subObjectKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ContractNumberType
    {

        private string contractCategoryField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string ContractCategory
        {
            get
            {
                return contractCategoryField;
            }
            set
            {
                contractCategoryField = value;
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
    [XmlInclude(typeof(ObjectDefinitionMachineType))]
    [XmlInclude(typeof(ObjectDefinitionType))]
    [XmlInclude(typeof(ObjectDefinitionObjectInstructionType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class CommonObjectDefinitionType
    {

        private UserIDType objectUserIDField;

        private string objectNameField;

        private ModificationDateType objectModificationDateField;

        private ForestCertificationType[] forestCertificationField;

        private LoggingFormType loggingFormField;

        private decimal objectAreaField;

        private bool objectAreaFieldSpecified;

        private LoggingOrganisationType loggingOrganisationField;

        private ContactInformationType forestOwnerField;

        private ContractNumberType contractNumberField;

        private RealEstateIDObjectType realEstateIDObjectField;

        private ContactInformationType auditingOrganisationField;

        private ExtensionType extensionField;

        /// <remarks/>
        public UserIDType ObjectUserID
        {
            get
            {
                return objectUserIDField;
            }
            set
            {
                objectUserIDField = value;
            }
        }

        /// <remarks/>
        public string ObjectName
        {
            get
            {
                return objectNameField;
            }
            set
            {
                objectNameField = value;
            }
        }

        /// <remarks/>
        public ModificationDateType ObjectModificationDate
        {
            get
            {
                return objectModificationDateField;
            }
            set
            {
                objectModificationDateField = value;
            }
        }

        /// <remarks/>
        [XmlElement("ForestCertification")]
        public ForestCertificationType[] ForestCertification
        {
            get
            {
                return forestCertificationField;
            }
            set
            {
                forestCertificationField = value;
            }
        }

        /// <remarks/>
        public LoggingFormType LoggingForm
        {
            get
            {
                return loggingFormField;
            }
            set
            {
                loggingFormField = value;
            }
        }

        /// <remarks/>
        public decimal ObjectArea
        {
            get
            {
                return objectAreaField;
            }
            set
            {
                objectAreaField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ObjectAreaSpecified
        {
            get
            {
                return objectAreaFieldSpecified;
            }
            set
            {
                objectAreaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LoggingOrganisationType LoggingOrganisation
        {
            get
            {
                return loggingOrganisationField;
            }
            set
            {
                loggingOrganisationField = value;
            }
        }

        /// <remarks/>
        public ContactInformationType ForestOwner
        {
            get
            {
                return forestOwnerField;
            }
            set
            {
                forestOwnerField = value;
            }
        }

        /// <remarks/>
        public ContractNumberType ContractNumber
        {
            get
            {
                return contractNumberField;
            }
            set
            {
                contractNumberField = value;
            }
        }

        /// <remarks/>
        public RealEstateIDObjectType RealEstateIDObject
        {
            get
            {
                return realEstateIDObjectField;
            }
            set
            {
                realEstateIDObjectField = value;
            }
        }

        /// <remarks/>
        public ContactInformationType AuditingOrganisation
        {
            get
            {
                return auditingOrganisationField;
            }
            set
            {
                auditingOrganisationField = value;
            }
        }

        /// <remarks/>
        public ExtensionType Extension
        {
            get
            {
                return extensionField;
            }
            set
            {
                extensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum ForestCertificationType
    {

        /// <remarks/>
        FSC,

        /// <remarks/>
        PEFC,

        /// <remarks/>
        Other,

        /// <remarks/>
        None,

        /// <remarks/>
        [XmlEnum("Not known")]
        Notknown,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ObjectDefinitionMachineType : CommonObjectDefinitionType
    {

        private string objectKeyField;

        private string textFromMachineField;

        private DateTime startDateField;

        private DateTime endDateField;

        private bool endDateFieldSpecified;

        private SubObjectDefinitionMachineType[] subObjectField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string ObjectKey
        {
            get
            {
                return objectKeyField;
            }
            set
            {
                objectKeyField = value;
            }
        }

        /// <remarks/>
        public string TextFromMachine
        {
            get
            {
                return textFromMachineField;
            }
            set
            {
                textFromMachineField = value;
            }
        }

        /// <remarks/>
        public DateTime StartDate
        {
            get
            {
                return startDateField;
            }
            set
            {
                startDateField = value;
            }
        }

        /// <remarks/>
        public DateTime EndDate
        {
            get
            {
                return endDateField;
            }
            set
            {
                endDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EndDateSpecified
        {
            get
            {
                return endDateFieldSpecified;
            }
            set
            {
                endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElement("SubObject")]
        public SubObjectDefinitionMachineType[] SubObject
        {
            get
            {
                return subObjectField;
            }
            set
            {
                subObjectField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(ObjectDefinitionObjectInstructionType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ObjectDefinitionType : CommonObjectDefinitionType
    {

        private string textToMachineField;

        private SubObjectDefinitionType[] subObjectField;

        /// <remarks/>
        public string TextToMachine
        {
            get
            {
                return textToMachineField;
            }
            set
            {
                textToMachineField = value;
            }
        }

        /// <remarks/>
        [XmlElement("SubObject")]
        public SubObjectDefinitionType[] SubObject
        {
            get
            {
                return subObjectField;
            }
            set
            {
                subObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ObjectDefinitionObjectInstructionType : ObjectDefinitionType
    {

        private UserIDType[] productUserIDField;

        private UserIDType[] diameterSectionUserIDField;

        /// <remarks/>
        [XmlElement("ProductUserID")]
        public UserIDType[] ProductUserID
        {
            get
            {
                return productUserIDField;
            }
            set
            {
                productUserIDField = value;
            }
        }

        /// <remarks/>
        [XmlElement("DiameterSectionUserID")]
        public UserIDType[] DiameterSectionUserID
        {
            get
            {
                return diameterSectionUserIDField;
            }
            set
            {
                diameterSectionUserIDField = value;
            }
        }
    }
}
