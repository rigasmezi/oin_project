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
    [XmlRoot("ProductInstruction", Namespace = "urn:skogforsk:stanford2010", IsNullable = false)]
    public partial class ProductInstructionType
    {

        private MessageHeaderType productInstructionHeaderField;

        private ProductDefinitionProductInstructionType[] productDefinitionField;

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

        public ProductInstructionType()
        {
            messageTypeField = MessageCategoryType.pin;
        }

        /// <remarks/>
        public MessageHeaderType ProductInstructionHeader
        {
            get
            {
                return productInstructionHeaderField;
            }
            set
            {
                productInstructionHeaderField = value;
            }
        }

        /// <remarks/>
        [XmlElement("ProductDefinition")]
        public ProductDefinitionProductInstructionType[] ProductDefinition
        {
            get
            {
                return productDefinitionField;
            }
            set
            {
                productDefinitionField = value;
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
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class MessageHeaderType
    {

        private string senderApplicationField;

        private DateTime creationDateField;

        private ModificationDateType modificationDateField;

        private string applicationVersionCreatedField;

        private string applicationVersionModifiedField;

        private string countryCodeField;

        private CoordinatesType creationCoordinatesField;

        /// <remarks/>
        public string SenderApplication
        {
            get
            {
                return senderApplicationField;
            }
            set
            {
                senderApplicationField = value;
            }
        }

        /// <remarks/>
        public DateTime CreationDate
        {
            get
            {
                return creationDateField;
            }
            set
            {
                creationDateField = value;
            }
        }

        /// <remarks/>
        public ModificationDateType ModificationDate
        {
            get
            {
                return modificationDateField;
            }
            set
            {
                modificationDateField = value;
            }
        }

        /// <remarks/>
        public string ApplicationVersionCreated
        {
            get
            {
                return applicationVersionCreatedField;
            }
            set
            {
                applicationVersionCreatedField = value;
            }
        }

        /// <remarks/>
        public string ApplicationVersionModified
        {
            get
            {
                return applicationVersionModifiedField;
            }
            set
            {
                applicationVersionModifiedField = value;
            }
        }

        /// <remarks/>
        public string CountryCode
        {
            get
            {
                return countryCodeField;
            }
            set
            {
                countryCodeField = value;
            }
        }

        /// <remarks/>
        public CoordinatesType CreationCoordinates
        {
            get
            {
                return creationCoordinatesField;
            }
            set
            {
                creationCoordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ModificationDateType
    {

        private string modificationAuthorField;

        private DateTime valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string modificationAuthor
        {
            get
            {
                return modificationAuthorField;
            }
            set
            {
                modificationAuthorField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public DateTime Value
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
    public partial class LogColorMarkingType
    {

        private bool color1Field;

        private bool color2Field;

        private bool color3Field;

        /// <remarks/>
        public bool Color1
        {
            get
            {
                return color1Field;
            }
            set
            {
                color1Field = value;
            }
        }

        /// <remarks/>
        public bool Color2
        {
            get
            {
                return color2Field;
            }
            set
            {
                color2Field = value;
            }
        }

        /// <remarks/>
        public bool Color3
        {
            get
            {
                return color3Field;
            }
            set
            {
                color3Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ProductMatrixItemType
    {

        private string priceField;

        private string distributionField;

        private string limitationField;

        private BuckingCriteriaType buckingCriteriaField;

        private bool buckingCriteriaFieldSpecified;

        private LogColorMarkingType logColorMarkingField;

        private string diameterClassLowerLimitField;

        private string lengthClassLowerLimitField;

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Price
        {
            get
            {
                return priceField;
            }
            set
            {
                priceField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Distribution
        {
            get
            {
                return distributionField;
            }
            set
            {
                distributionField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Limitation
        {
            get
            {
                return limitationField;
            }
            set
            {
                limitationField = value;
            }
        }

        /// <remarks/>
        public BuckingCriteriaType BuckingCriteria
        {
            get
            {
                return buckingCriteriaField;
            }
            set
            {
                buckingCriteriaField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool BuckingCriteriaSpecified
        {
            get
            {
                return buckingCriteriaFieldSpecified;
            }
            set
            {
                buckingCriteriaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LogColorMarkingType LogColorMarking
        {
            get
            {
                return logColorMarkingField;
            }
            set
            {
                logColorMarkingField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(DataType = "positiveInteger")]
        public string diameterClassLowerLimit
        {
            get
            {
                return diameterClassLowerLimitField;
            }
            set
            {
                diameterClassLowerLimitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(DataType = "positiveInteger")]
        public string lengthClassLowerLimit
        {
            get
            {
                return lengthClassLowerLimitField;
            }
            set
            {
                lengthClassLowerLimitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum BuckingCriteriaType
    {

        /// <remarks/>
        [XmlEnum("No limit")]
        Nolimit,

        /// <remarks/>
        [XmlEnum("Forbidden to buck the log even manually")]
        Forbiddentobuckthelogevenmanually,

        /// <remarks/>
        [XmlEnum("The log is excluded from apportionment bucking,only bucking according to value al" +
            "lowed")]
        Thelogisexcludedfromapportionmentbuckingonlybuckingaccordingtovalueallowed,

        /// <remarks/>
        [XmlEnum("Only logs bucked manually allowed")]
        Onlylogsbuckedmanuallyallowed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ProductMatrixType
    {

        private ProductMatrixItemType[] productMatrixItemField;

        private bool modificationRestrictedPriceField;

        private bool modificationRestrictedDistributionField;

        private bool modificationRestrictedLimitationField;

        private bool modificationRestrictedBuckingCriteriaField;

        private bool modificationRestrictedLogColorMarkingField;

        /// <remarks/>
        [XmlElement("ProductMatrixItem")]
        public ProductMatrixItemType[] ProductMatrixItem
        {
            get
            {
                return productMatrixItemField;
            }
            set
            {
                productMatrixItemField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestrictedPrice
        {
            get
            {
                return modificationRestrictedPriceField;
            }
            set
            {
                modificationRestrictedPriceField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestrictedDistribution
        {
            get
            {
                return modificationRestrictedDistributionField;
            }
            set
            {
                modificationRestrictedDistributionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestrictedLimitation
        {
            get
            {
                return modificationRestrictedLimitationField;
            }
            set
            {
                modificationRestrictedLimitationField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestrictedBuckingCriteria
        {
            get
            {
                return modificationRestrictedBuckingCriteriaField;
            }
            set
            {
                modificationRestrictedBuckingCriteriaField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestrictedLogColorMarking
        {
            get
            {
                return modificationRestrictedLogColorMarkingField;
            }
            set
            {
                modificationRestrictedLogColorMarkingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LimitationDefinitionType
    {

        private LimitationCategoryType limitationCategoryField;

        private LimitationResultType limitationResultField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public LimitationCategoryType LimitationCategory
        {
            get
            {
                return limitationCategoryField;
            }
            set
            {
                limitationCategoryField = value;
            }
        }

        /// <remarks/>
        public LimitationResultType LimitationResult
        {
            get
            {
                return limitationResultField;
            }
            set
            {
                limitationResultField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum LimitationCategoryType
    {

        /// <remarks/>
        [XmlEnum("No limitation")]
        Nolimitation,

        /// <remarks/>
        [XmlEnum("Total number, quantity per product")]
        Totalnumberquantityperproduct,

        /// <remarks/>
        [XmlEnum("Total volume, m3 per product")]
        Totalvolumem3perproduct,

        /// <remarks/>
        [XmlEnum("Number per diameter class per product")]
        Numberperdiameterclassperproduct,

        /// <remarks/>
        [XmlEnum("Volume per diameter class per product")]
        Volumeperdiameterclassperproduct,

        /// <remarks/>
        [XmlEnum("Number per length class per product")]
        Numberperlengthclassperproduct,

        /// <remarks/>
        [XmlEnum("Volume per length class per product")]
        Volumeperlengthclassperproduct,

        /// <remarks/>
        [XmlEnum("Number per cell (log size class) per product and tree species")]
        Numberpercelllogsizeclassperproductandtreespecies,

        /// <remarks/>
        [XmlEnum("Volume per cell (log size class) per product and tree species")]
        Volumepercelllogsizeclassperproductandtreespecies,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum LimitationResultType
    {

        /// <remarks/>
        [XmlEnum("No action")]
        Noaction,

        /// <remarks/>
        [XmlEnum("Production is stopped, forbidden to buck logs, only manually bucked logs allowed")]
        Productionisstoppedforbiddentobucklogsonlymanuallybuckedlogsallowed,

        /// <remarks/>
        [XmlEnum("Production is stopped, forbidden to buck logs including manual bucking of logs")]
        Productionisstoppedforbiddentobucklogsincludingmanualbuckingoflogs,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LengthDistributionDefinitionType
    {

        private bool distributionAllowedField;

        private DistributionCategoryType distributionCategoryField;

        private decimal mAXDeviationField;

        private bool distributionWithinProductField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public bool DistributionAllowed
        {
            get
            {
                return distributionAllowedField;
            }
            set
            {
                distributionAllowedField = value;
            }
        }

        /// <remarks/>
        public DistributionCategoryType DistributionCategory
        {
            get
            {
                return distributionCategoryField;
            }
            set
            {
                distributionCategoryField = value;
            }
        }

        /// <remarks/>
        public decimal MAXDeviation
        {
            get
            {
                return mAXDeviationField;
            }
            set
            {
                mAXDeviationField = value;
            }
        }

        /// <remarks/>
        public bool DistributionWithinProduct
        {
            get
            {
                return distributionWithinProductField;
            }
            set
            {
                distributionWithinProductField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum DistributionCategoryType
    {

        /// <remarks/>
        [XmlEnum("Number of logs")]
        Numberoflogs,

        /// <remarks/>
        [XmlEnum("Volume of logs")]
        Volumeoflogs,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class PermittedGradesDefinitionType
    {

        private string[] permittedGradeNumberField;

        private string gradeToleranceTopField;

        private string gradeToleranceButtField;

        private bool modificationRestrictedField;

        /// <remarks/>
        [XmlElement("PermittedGradeNumber", DataType = "positiveInteger")]
        public string[] PermittedGradeNumber
        {
            get
            {
                return permittedGradeNumberField;
            }
            set
            {
                permittedGradeNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string GradeToleranceTop
        {
            get
            {
                return gradeToleranceTopField;
            }
            set
            {
                gradeToleranceTopField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string GradeToleranceButt
        {
            get
            {
                return gradeToleranceButtField;
            }
            set
            {
                gradeToleranceButtField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class CuttingWindowDefinitionType
    {

        private string lowerLengthLimitField;

        private string upperLengthLimitField;

        private bool modificationRestrictedField;

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string LowerLengthLimit
        {
            get
            {
                return lowerLengthLimitField;
            }
            set
            {
                lowerLengthLimitField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "integer")]
        public string UpperLengthLimit
        {
            get
            {
                return upperLengthLimitField;
            }
            set
            {
                upperLengthLimitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class VolumeDiameterCategoryBaseType
    {

        private string volumeDiameterTopPositionField;

        private VolumeDiameterCategoryType valueField;

        /// <remarks/>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string volumeDiameterTopPosition
        {
            get
            {
                return volumeDiameterTopPositionField;
            }
            set
            {
                volumeDiameterTopPositionField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public VolumeDiameterCategoryType Value
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
    public enum VolumeDiameterCategoryType
    {

        /// <remarks/>
        [XmlEnum("All diameters (solid volume)")]
        Alldiameterssolidvolume,

        /// <remarks/>
        Top,

        /// <remarks/>
        Mid,

        /// <remarks/>
        [XmlEnum("Calculated Norwegian mid")]
        CalculatedNorwegianmid,

        /// <remarks/>
        [XmlEnum("Calculated Estonian mid")]
        CalculatedEstonianmid,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class PriceDefinitionType
    {

        private VolumeDiameterAdjustmentType volumeDiameterAdjustmentField;

        private VolumeDiameterCategoryBaseType volumeDiameterCategoryField;

        private VolumeLengthCategoryType volumeLengthCategoryField;

        private bool volumeUnderBarkField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public VolumeDiameterAdjustmentType VolumeDiameterAdjustment
        {
            get
            {
                return volumeDiameterAdjustmentField;
            }
            set
            {
                volumeDiameterAdjustmentField = value;
            }
        }

        /// <remarks/>
        public VolumeDiameterCategoryBaseType VolumeDiameterCategory
        {
            get
            {
                return volumeDiameterCategoryField;
            }
            set
            {
                volumeDiameterCategoryField = value;
            }
        }

        /// <remarks/>
        public VolumeLengthCategoryType VolumeLengthCategory
        {
            get
            {
                return volumeLengthCategoryField;
            }
            set
            {
                volumeLengthCategoryField = value;
            }
        }

        /// <remarks/>
        public bool VolumeUnderBark
        {
            get
            {
                return volumeUnderBarkField;
            }
            set
            {
                volumeUnderBarkField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum VolumeDiameterAdjustmentType
    {

        /// <remarks/>
        [XmlEnum("Measured diameter in mm")]
        Measureddiameterinmm,

        /// <remarks/>
        [XmlEnum("Measured diameter rounded downwards to cm")]
        Measureddiameterroundeddownwardstocm,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum VolumeLengthCategoryType
    {

        /// <remarks/>
        [XmlEnum("Physical length cm")]
        Physicallengthcm,

        /// <remarks/>
        [XmlEnum("Length as defined in LengthClasses")]
        LengthasdefinedinLengthClasses,

        /// <remarks/>
        [XmlEnum("Rounded downwards to nearest dm-module")]
        Roundeddownwardstonearestdmmodule,

        /// <remarks/>
        [XmlEnum("Rounded to nearest mid-dm")]
        Roundedtonearestmiddm,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LongTimberDefinitionType
    {

        private string longLogButtMINField;

        private string longLogButtMAXField;

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string LongLogButtMIN
        {
            get
            {
                return longLogButtMINField;
            }
            set
            {
                longLogButtMINField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string LongLogButtMAX
        {
            get
            {
                return longLogButtMAXField;
            }
            set
            {
                longLogButtMAXField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LengthClassType
    {

        private string lengthClassLowerLimitField;

        private string lengthClassMarginField;

        private LongTimberDefinitionType longTimberDefinitionField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string LengthClassLowerLimit
        {
            get
            {
                return lengthClassLowerLimitField;
            }
            set
            {
                lengthClassLowerLimitField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string LengthClassMargin
        {
            get
            {
                return lengthClassMarginField;
            }
            set
            {
                lengthClassMarginField = value;
            }
        }

        /// <remarks/>
        public LongTimberDefinitionType LongTimberDefinition
        {
            get
            {
                return longTimberDefinitionField;
            }
            set
            {
                longTimberDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LengthDefinitionType
    {

        private LengthClassAdjustmentType lengthClassAdjustmentField;

        private LengthClassType[] lengthClassField;

        private string lengthClassMAXField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public LengthClassAdjustmentType LengthClassAdjustment
        {
            get
            {
                return lengthClassAdjustmentField;
            }
            set
            {
                lengthClassAdjustmentField = value;
            }
        }

        /// <remarks/>
        [XmlElement("LengthClass")]
        public LengthClassType[] LengthClass
        {
            get
            {
                return lengthClassField;
            }
            set
            {
                lengthClassField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string LengthClassMAX
        {
            get
            {
                return lengthClassMAXField;
            }
            set
            {
                lengthClassMAXField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum LengthClassAdjustmentType
    {

        /// <remarks/>
        LengthClassAdjustment1,

        /// <remarks/>
        LengthClassAdjustment2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterClassType
    {

        private string diameterClassLowerLimitField;

        private string diameterClassNameField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string DiameterClassLowerLimit
        {
            get
            {
                return diameterClassLowerLimitField;
            }
            set
            {
                diameterClassLowerLimitField = value;
            }
        }

        /// <remarks/>
        public string DiameterClassName
        {
            get
            {
                return diameterClassNameField;
            }
            set
            {
                diameterClassNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterClassesType
    {

        private DiameterClassType[] diameterClassField;

        private string diameterClassMAXField;

        private DiameterClassAdjustmentType diameterClassAdjustmentField;

        private bool diameterUnderBarkField;

        private DiameterClassCategoryType diameterClassCategoryField;

        /// <remarks/>
        [XmlElement("DiameterClass")]
        public DiameterClassType[] DiameterClass
        {
            get
            {
                return diameterClassField;
            }
            set
            {
                diameterClassField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string DiameterClassMAX
        {
            get
            {
                return diameterClassMAXField;
            }
            set
            {
                diameterClassMAXField = value;
            }
        }

        /// <remarks/>
        public DiameterClassAdjustmentType DiameterClassAdjustment
        {
            get
            {
                return diameterClassAdjustmentField;
            }
            set
            {
                diameterClassAdjustmentField = value;
            }
        }

        /// <remarks/>
        public bool DiameterUnderBark
        {
            get
            {
                return diameterUnderBarkField;
            }
            set
            {
                diameterUnderBarkField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DiameterClassCategoryType diameterClassCategory
        {
            get
            {
                return diameterClassCategoryField;
            }
            set
            {
                diameterClassCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum DiameterClassAdjustmentType
    {

        /// <remarks/>
        DiameterClassAdjustment1,

        /// <remarks/>
        DiameterClassAdjustment2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum DiameterClassCategoryType
    {

        /// <remarks/>
        Top,

        /// <remarks/>
        Midpoint,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class DiameterDefinitionType
    {

        private DiameterClassesType diameterClassesField;

        private string diameterMINTopField;

        private string diameterMAXButtField;

        private string diameterTopPositionField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public DiameterClassesType DiameterClasses
        {
            get
            {
                return diameterClassesField;
            }
            set
            {
                diameterClassesField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string DiameterMINTop
        {
            get
            {
                return diameterMINTopField;
            }
            set
            {
                diameterMINTopField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string DiameterMAXButt
        {
            get
            {
                return diameterMAXButtField;
            }
            set
            {
                diameterMAXButtField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string DiameterTopPosition
        {
            get
            {
                return diameterTopPositionField;
            }
            set
            {
                diameterTopPositionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LoggingOrganisationType
    {

        private ContactInformationType contactInformationField;

        private string districtField;

        private string teamField;

        /// <remarks/>
        public ContactInformationType ContactInformation
        {
            get
            {
                return contactInformationField;
            }
            set
            {
                contactInformationField = value;
            }
        }

        /// <remarks/>
        public string District
        {
            get
            {
                return districtField;
            }
            set
            {
                districtField = value;
            }
        }

        /// <remarks/>
        public string Team
        {
            get
            {
                return teamField;
            }
            set
            {
                teamField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class VersionType
    {

        private bool modificationRestrictedField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
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
    public partial class InfoType
    {

        private bool modificationRestrictedField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public bool modificationRestricted
        {
            get
            {
                return modificationRestrictedField;
            }
            set
            {
                modificationRestrictedField = value;
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
    [XmlInclude(typeof(ProductDefinitionWithCommonDetailsType))]
    [XmlInclude(typeof(ProductDefinitionWithDetailsType))]
    [XmlInclude(typeof(ClassifiedProductDefinitionProductInstructionType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public abstract partial class CommonProductDefinitionType
    {

        private string productNameField;

        private ModificationDateType modificationDateField;

        private InfoType productInfoField;

        private VersionType productVersionField;

        private ContactInformationType productBuyerField;

        private string productClassField;

        private LoggingOrganisationType loggingOrganisationField;

        private ContactInformationType[] productDestinationField;

        private string productGroupNameField;

        private string stemTypeCodeField;

        private ExtensionType extensionField;

        private string productPresentationOrderField;

        private string productDescriptionField;

        /// <remarks/>
        public string ProductName
        {
            get
            {
                return productNameField;
            }
            set
            {
                productNameField = value;
            }
        }

        /// <remarks/>
        public ModificationDateType ModificationDate
        {
            get
            {
                return modificationDateField;
            }
            set
            {
                modificationDateField = value;
            }
        }

        /// <remarks/>
        public InfoType ProductInfo
        {
            get
            {
                return productInfoField;
            }
            set
            {
                productInfoField = value;
            }
        }

        /// <remarks/>
        public VersionType ProductVersion
        {
            get
            {
                return productVersionField;
            }
            set
            {
                productVersionField = value;
            }
        }

        /// <remarks/>
        public ContactInformationType ProductBuyer
        {
            get
            {
                return productBuyerField;
            }
            set
            {
                productBuyerField = value;
            }
        }

        /// <remarks/>
        public string ProductClass
        {
            get
            {
                return productClassField;
            }
            set
            {
                productClassField = value;
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
        [XmlElement("ProductDestination")]
        public ContactInformationType[] ProductDestination
        {
            get
            {
                return productDestinationField;
            }
            set
            {
                productDestinationField = value;
            }
        }

        /// <remarks/>
        public string ProductGroupName
        {
            get
            {
                return productGroupNameField;
            }
            set
            {
                productGroupNameField = value;
            }
        }

        /// <remarks/>
        public string StemTypeCode
        {
            get
            {
                return stemTypeCodeField;
            }
            set
            {
                stemTypeCodeField = value;
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
        [XmlElement(DataType = "positiveInteger")]
        public string ProductPresentationOrder
        {
            get
            {
                return productPresentationOrderField;
            }
            set
            {
                productPresentationOrderField = value;
            }
        }

        /// <remarks/>
        public string ProductDescription
        {
            get
            {
                return productDescriptionField;
            }
            set
            {
                productDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(ProductDefinitionWithDetailsType))]
    [XmlInclude(typeof(ClassifiedProductDefinitionProductInstructionType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ProductDefinitionWithCommonDetailsType : CommonProductDefinitionType
    {

        private DiameterDefinitionType diameterDefinitionField;

        private LengthDefinitionType lengthDefinitionField;

        private PriceDefinitionType priceDefinitionField;

        /// <remarks/>
        public DiameterDefinitionType DiameterDefinition
        {
            get
            {
                return diameterDefinitionField;
            }
            set
            {
                diameterDefinitionField = value;
            }
        }

        /// <remarks/>
        public LengthDefinitionType LengthDefinition
        {
            get
            {
                return lengthDefinitionField;
            }
            set
            {
                lengthDefinitionField = value;
            }
        }

        /// <remarks/>
        public PriceDefinitionType PriceDefinition
        {
            get
            {
                return priceDefinitionField;
            }
            set
            {
                priceDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(ClassifiedProductDefinitionProductInstructionType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ProductDefinitionWithDetailsType : ProductDefinitionWithCommonDetailsType
    {

        private DateTime productCreationDateField;

        private bool productCreationDateFieldSpecified;

        private bool manualFreeBuckField;

        private bool topLogFreeBuckField;

        private ProductConditionType productConditionField;

        private CuttingWindowDefinitionType cuttingWindowDefinitionField;

        private PermittedGradesDefinitionType permittedGradesDefinitionField;

        private LengthDistributionDefinitionType lengthDistributionDefinitionField;

        private LimitationDefinitionType limitationDefinitionField;

        private ProductMatrixType productMatrixesField;

        private string longLogButtHeightField;

        /// <remarks/>
        public DateTime ProductCreationDate
        {
            get
            {
                return productCreationDateField;
            }
            set
            {
                productCreationDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool ProductCreationDateSpecified
        {
            get
            {
                return productCreationDateFieldSpecified;
            }
            set
            {
                productCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ManualFreeBuck
        {
            get
            {
                return manualFreeBuckField;
            }
            set
            {
                manualFreeBuckField = value;
            }
        }

        /// <remarks/>
        public bool TopLogFreeBuck
        {
            get
            {
                return topLogFreeBuckField;
            }
            set
            {
                topLogFreeBuckField = value;
            }
        }

        /// <remarks/>
        public ProductConditionType ProductCondition
        {
            get
            {
                return productConditionField;
            }
            set
            {
                productConditionField = value;
            }
        }

        /// <remarks/>
        public CuttingWindowDefinitionType CuttingWindowDefinition
        {
            get
            {
                return cuttingWindowDefinitionField;
            }
            set
            {
                cuttingWindowDefinitionField = value;
            }
        }

        /// <remarks/>
        public PermittedGradesDefinitionType PermittedGradesDefinition
        {
            get
            {
                return permittedGradesDefinitionField;
            }
            set
            {
                permittedGradesDefinitionField = value;
            }
        }

        /// <remarks/>
        public LengthDistributionDefinitionType LengthDistributionDefinition
        {
            get
            {
                return lengthDistributionDefinitionField;
            }
            set
            {
                lengthDistributionDefinitionField = value;
            }
        }

        /// <remarks/>
        public LimitationDefinitionType LimitationDefinition
        {
            get
            {
                return limitationDefinitionField;
            }
            set
            {
                limitationDefinitionField = value;
            }
        }

        /// <remarks/>
        public ProductMatrixType ProductMatrixes
        {
            get
            {
                return productMatrixesField;
            }
            set
            {
                productMatrixesField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string LongLogButtHeight
        {
            get
            {
                return longLogButtHeightField;
            }
            set
            {
                longLogButtHeightField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum ProductConditionType
    {

        /// <remarks/>
        [XmlEnum("Buck always")]
        Buckalways,

        /// <remarks/>
        [XmlEnum("Buck butt-log only")]
        Buckbuttlogonly,

        /// <remarks/>
        [XmlEnum("Do not buck butt log")]
        Donotbuckbuttlog,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ClassifiedProductDefinitionProductInstructionType : ProductDefinitionWithDetailsType
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
    public partial class ProductDefinitionProductInstructionType
    {

        private UserIDType productUserIDField;

        private ClassifiedProductDefinitionProductInstructionType itemField;

        private UserIDType SpeciesGroupUserIDField;

        /// <remarks/>
        public UserIDType ProductUserID
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
        [XmlElement("ClassifiedProductDefinition")]
        public ClassifiedProductDefinitionProductInstructionType Item
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

        public UserIDType SpeciesGroupUserID
        {
            get
            {
                return SpeciesGroupUserIDField;
            }
            set
            {
                SpeciesGroupUserIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LongitudeType
    {

        private LongitudeCategoryType longitudeCategoryField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public LongitudeCategoryType longitudeCategory
        {
            get
            {
                return longitudeCategoryField;
            }
            set
            {
                longitudeCategoryField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
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
    public enum LongitudeCategoryType
    {

        /// <remarks/>
        East,

        /// <remarks/>
        West,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class LatitudeType
    {

        private LatitudeCategoryType latitudeCategoryField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public LatitudeCategoryType latitudeCategory
        {
            get
            {
                return latitudeCategoryField;
            }
            set
            {
                latitudeCategoryField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
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
    public enum LatitudeCategoryType
    {

        /// <remarks/>
        North,

        /// <remarks/>
        South,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class CoordinatesType
    {

        private LatitudeType latitudeField;

        private LongitudeType longitudeField;

        private decimal altitudeField;

        private DateTime coordinateDateField;

        private bool coordinateDateFieldSpecified;

        private ReceiverPositionType receiverPositionField;

        private CoordinateReferenceSystemType coordinateReferenceSystemField;

        /// <remarks/>
        public LatitudeType Latitude
        {
            get
            {
                return latitudeField;
            }
            set
            {
                latitudeField = value;
            }
        }

        /// <remarks/>
        public LongitudeType Longitude
        {
            get
            {
                return longitudeField;
            }
            set
            {
                longitudeField = value;
            }
        }

        /// <remarks/>
        public decimal Altitude
        {
            get
            {
                return altitudeField;
            }
            set
            {
                altitudeField = value;
            }
        }

        /// <remarks/>
        public DateTime CoordinateDate
        {
            get
            {
                return coordinateDateField;
            }
            set
            {
                coordinateDateField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool CoordinateDateSpecified
        {
            get
            {
                return coordinateDateFieldSpecified;
            }
            set
            {
                coordinateDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ReceiverPositionType receiverPosition
        {
            get
            {
                return receiverPositionField;
            }
            set
            {
                receiverPositionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public CoordinateReferenceSystemType coordinateReferenceSystem
        {
            get
            {
                return coordinateReferenceSystemField;
            }
            set
            {
                coordinateReferenceSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum ReceiverPositionType
    {

        /// <remarks/>
        [XmlEnum("Base machine position")]
        Basemachineposition,

        /// <remarks/>
        [XmlEnum("Crane tip position when felling the tree")]
        Cranetippositionwhenfellingthetree,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum CoordinateReferenceSystemType
    {

        /// <remarks/>
        WGS84,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum AreaUnitType
    {

        /// <remarks/>
        ha,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum DiameterUnitType
    {

        /// <remarks/>
        mm,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum LengthUnitType
    {

        /// <remarks/>
        cm,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum VolumeUnitType
    {

        /// <remarks/>
        m3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum WeightUnitType
    {

        /// <remarks/>
        kg,
    }
}
