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
    [XmlRoot("SpeciesGroupInstruction", Namespace = "urn:skogforsk:stanford2010", IsNullable = false)]
    public partial class SpeciesGroupInstructionType
    {

        private MessageHeaderType speciesGroupInstructionHeaderField;

        private SpeciesGroupDefinitionSpeciesGroupInstructionType[] speciesGroupDefinitionField;

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

        public SpeciesGroupInstructionType()
        {
            messageTypeField = MessageCategoryType.spi;
        }

        /// <remarks/>
        public MessageHeaderType SpeciesGroupInstructionHeader
        {
            get
            {
                return speciesGroupInstructionHeaderField;
            }
            set
            {
                speciesGroupInstructionHeaderField = value;
            }
        }

        /// <remarks/>
        [XmlElement("SpeciesGroupDefinition")]
        public SpeciesGroupDefinitionSpeciesGroupInstructionType[] SpeciesGroupDefinition
        {
            get
            {
                return speciesGroupDefinitionField;
            }
            set
            {
                speciesGroupDefinitionField = value;
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
    public partial class SpeciesDefinitionType
    {

        private string speciesNameField;

        private string speciesUserIDField;

        /// <remarks/>
        public string SpeciesName
        {
            get
            {
                return speciesNameField;
            }
            set
            {
                speciesNameField = value;
            }
        }

        /// <remarks/>
        public string SpeciesUserID
        {
            get
            {
                return speciesUserIDField;
            }
            set
            {
                speciesUserIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class StemCodeType
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
    public partial class EstonianVolumeParametersType
    {

        private decimal parameterA1Field;

        private decimal parameterA2Field;

        private decimal parameterA3Field;

        /// <remarks/>
        public decimal ParameterA1
        {
            get
            {
                return parameterA1Field;
            }
            set
            {
                parameterA1Field = value;
            }
        }

        /// <remarks/>
        public decimal ParameterA2
        {
            get
            {
                return parameterA2Field;
            }
            set
            {
                parameterA2Field = value;
            }
        }

        /// <remarks/>
        public decimal ParameterA3
        {
            get
            {
                return parameterA3Field;
            }
            set
            {
                parameterA3Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ButtEndProfileExtrapolationFunctionParameterType
    {

        private string parameterNameField;

        private decimal parameterValueField;

        /// <remarks/>
        public string ParameterName
        {
            get
            {
                return parameterNameField;
            }
            set
            {
                parameterNameField = value;
            }
        }

        /// <remarks/>
        public decimal ParameterValue
        {
            get
            {
                return parameterValueField;
            }
            set
            {
                parameterValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ButtEndProfileExtrapolationFunctionType
    {

        private ButtEndProfileExtrapolationFunctionParameterType[] parameterField;

        private ButtEndProfileExtrapolationFunctionCategoryType buttEndProfileExtrapolationFunctionCategoryField;

        /// <remarks/>
        [XmlElement("Parameter")]
        public ButtEndProfileExtrapolationFunctionParameterType[] Parameter
        {
            get
            {
                return parameterField;
            }
            set
            {
                parameterField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ButtEndProfileExtrapolationFunctionCategoryType ButtEndProfileExtrapolationFunctionCategory
        {
            get
            {
                return buttEndProfileExtrapolationFunctionCategoryField;
            }
            set
            {
                buttEndProfileExtrapolationFunctionCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public enum ButtEndProfileExtrapolationFunctionCategoryType
    {

        /// <remarks/>
        [XmlEnum("Poikela 2007")]
        Poikela2007,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ExtrapolationCoefficientType
    {

        private string diameterClassField;

        private string distanceClassField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string diameterClass
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
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string distanceClass
        {
            get
            {
                return distanceClassField;
            }
            set
            {
                distanceClassField = value;
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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class ButtEndProfileExtrapolationType
    {

        private string referenceHeightField;

        private ExtrapolationCoefficientType[] buttEndProfileExtrapolationTableField;

        private ButtEndProfileExtrapolationFunctionType buttEndProfileExtrapolationFunctionField;

        private ButtEndProfileExtrapolationMethodType buttEndProfileExtrapolationMethodField;

        private bool modificationRestrictedField;

        /// <remarks/>
        [XmlElement(DataType = "nonNegativeInteger")]
        public string ReferenceHeight
        {
            get
            {
                return referenceHeightField;
            }
            set
            {
                referenceHeightField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("ExtrapolationCoefficient", IsNullable = false)]
        public ExtrapolationCoefficientType[] ButtEndProfileExtrapolationTable
        {
            get
            {
                return buttEndProfileExtrapolationTableField;
            }
            set
            {
                buttEndProfileExtrapolationTableField = value;
            }
        }

        /// <remarks/>
        public ButtEndProfileExtrapolationFunctionType ButtEndProfileExtrapolationFunction
        {
            get
            {
                return buttEndProfileExtrapolationFunctionField;
            }
            set
            {
                buttEndProfileExtrapolationFunctionField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ButtEndProfileExtrapolationMethodType buttEndProfileExtrapolationMethod
        {
            get
            {
                return buttEndProfileExtrapolationMethodField;
            }
            set
            {
                buttEndProfileExtrapolationMethodField = value;
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
    public enum ButtEndProfileExtrapolationMethodType
    {

        /// <remarks/>
        ExtrapolationFunction,

        /// <remarks/>
        ExtrapolationTable,

        /// <remarks/>
        Both,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SoundKnotFunctionType
    {

        private decimal constantAField;

        private decimal factorBField;

        private decimal factorCField;

        private decimal toleranceDField;

        private string soundKnotFunctionGradeField;

        private string[] gradeIncludedField;

        private bool modificationRestrictedField;

        /// <remarks/>
        public decimal ConstantA
        {
            get
            {
                return constantAField;
            }
            set
            {
                constantAField = value;
            }
        }

        /// <remarks/>
        public decimal FactorB
        {
            get
            {
                return factorBField;
            }
            set
            {
                factorBField = value;
            }
        }

        /// <remarks/>
        public decimal FactorC
        {
            get
            {
                return factorCField;
            }
            set
            {
                factorCField = value;
            }
        }

        /// <remarks/>
        public decimal ToleranceD
        {
            get
            {
                return toleranceDField;
            }
            set
            {
                toleranceDField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string SoundKnotFunctionGrade
        {
            get
            {
                return soundKnotFunctionGradeField;
            }
            set
            {
                soundKnotFunctionGradeField = value;
            }
        }

        /// <remarks/>
        [XmlElement("GradeIncluded", DataType = "positiveInteger")]
        public string[] GradeIncluded
        {
            get
            {
                return gradeIncludedField;
            }
            set
            {
                gradeIncludedField = value;
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
    public partial class Skogforsk2004ScotsPineType
    {

        private decimal latitudeField;

        private bool latitudeFieldSpecified;

        /// <remarks/>
        public decimal Latitude
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
        [XmlIgnore()]
        public bool LatitudeSpecified
        {
            get
            {
                return latitudeFieldSpecified;
            }
            set
            {
                latitudeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class BarkDeductionDistanceType
    {

        private string distanceClassLowerLimitField;

        private string dBHClassLowerLimitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string distanceClassLowerLimit
        {
            get
            {
                return distanceClassLowerLimitField;
            }
            set
            {
                distanceClassLowerLimitField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string dBHClassLowerLimit
        {
            get
            {
                return dBHClassLowerLimitField;
            }
            set
            {
                dBHClassLowerLimitField = value;
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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class GermanDistanceType
    {

        private BarkDeductionDistanceType[] barkDeductionField;

        private string[] distanceClassLowerLimitField;

        private string[] dBHClassLowerLimitField;

        /// <remarks/>
        [XmlElement("BarkDeduction")]
        public BarkDeductionDistanceType[] BarkDeduction
        {
            get
            {
                return barkDeductionField;
            }
            set
            {
                barkDeductionField = value;
            }
        }

        /// <remarks/>
        [XmlElement("DistanceClassLowerLimit", DataType = "nonNegativeInteger")]
        public string[] DistanceClassLowerLimit
        {
            get
            {
                return distanceClassLowerLimitField;
            }
            set
            {
                distanceClassLowerLimitField = value;
            }
        }

        /// <remarks/>
        [XmlElement("DBHClassLowerLimit", DataType = "nonNegativeInteger")]
        public string[] DBHClassLowerLimit
        {
            get
            {
                return dBHClassLowerLimitField;
            }
            set
            {
                dBHClassLowerLimitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class GermanType
    {

        private BarkDeductionType[] barkDeductionField;

        /// <remarks/>
        [XmlElement("BarkDeduction")]
        public BarkDeductionType[] BarkDeduction
        {
            get
            {
                return barkDeductionField;
            }
            set
            {
                barkDeductionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class BarkDeductionType
    {

        private string lowerDiameterLimitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute(DataType = "nonNegativeInteger")]
        public string lowerDiameterLimit
        {
            get
            {
                return lowerDiameterLimitField;
            }
            set
            {
                lowerDiameterLimitField = value;
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
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SwedishZaccoType
    {

        private decimal constantAField;

        private decimal factorBField;

        /// <remarks/>
        public decimal ConstantA
        {
            get
            {
                return constantAField;
            }
            set
            {
                constantAField = value;
            }
        }

        /// <remarks/>
        public decimal FactorB
        {
            get
            {
                return factorBField;
            }
            set
            {
                factorBField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class BarkFunctionType
    {

        private object itemField;

        private BarkFunctionCategoryType barkFunctionCategoryField;

        private bool modificationRestrictedField;

        /// <remarks/>
        [XmlElement("German", typeof(GermanType))]
        [XmlElement("GermanDistanceBased", typeof(GermanDistanceType))]
        [XmlElement("Skogforsk2004ScotsPine", typeof(Skogforsk2004ScotsPineType))]
        [XmlElement("SwedishZacco", typeof(SwedishZaccoType))]
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
        [XmlAttribute()]
        public BarkFunctionCategoryType barkFunctionCategory
        {
            get
            {
                return barkFunctionCategoryField;
            }
            set
            {
                barkFunctionCategoryField = value;
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
    public enum BarkFunctionCategoryType
    {

        /// <remarks/>
        None,

        /// <remarks/>
        [XmlEnum("Swedish Zacco")]
        SwedishZacco,

        /// <remarks/>
        German,

        /// <remarks/>
        GermanDistanceBased,

        /// <remarks/>
        [XmlEnum("Skogforsk 2004, Scots pine")]
        Skogforsk2004Scotspine,

        /// <remarks/>
        [XmlEnum("Skogforsk 2004, Norway spruce")]
        Skogforsk2004Norwayspruce,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class GradeType
    {

        private string gradeNumberField;

        private string gradeNameField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string GradeNumber
        {
            get
            {
                return gradeNumberField;
            }
            set
            {
                gradeNumberField = value;
            }
        }

        /// <remarks/>
        public string GradeName
        {
            get
            {
                return gradeNameField;
            }
            set
            {
                gradeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class GradesType
    {

        private string startGradeField;

        private string mTHStartGradeField;

        private GradeType[] gradeField;

        private bool modificationRestrictedField;

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string StartGrade
        {
            get
            {
                return startGradeField;
            }
            set
            {
                startGradeField = value;
            }
        }

        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string MTHStartGrade
        {
            get
            {
                return mTHStartGradeField;
            }
            set
            {
                mTHStartGradeField = value;
            }
        }

        /// <remarks/>
        [XmlElement("Grade")]
        public GradeType[] Grade
        {
            get
            {
                return gradeField;
            }
            set
            {
                gradeField = value;
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
    public partial class DBHHeightType
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
        [XmlText(DataType = "positiveInteger")]
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
    public partial class StemTypeDefinitionType
    {

        private string stemTypeCodeField;

        private string stemTypeNameField;

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
        public string StemTypeName
        {
            get
            {
                return stemTypeNameField;
            }
            set
            {
                stemTypeNameField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(SpeciesGroupDefinitionWithDetailsType))]
    [XmlInclude(typeof(SpeciesGroupDefinitionSpeciesGroupInstructionType))]
    [XmlInclude(typeof(SpeciesGroupDefinitionWithDetailsAndKeyType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class CommonSpeciesGroupDefinitionType
    {

        private ModificationDateType speciesGroupModificationDateField;

        private UserIDType speciesGroupUserIDField;

        private string speciesGroupNameField;

        private InfoType speciesGroupInfoField;

        private VersionType speciesGroupVersionField;

        private StemTypeDefinitionType[] stemTypeDefinitionField;

        private LoggingOrganisationType loggingOrganisationField;

        private ExtensionType extensionField;

        private string speciesGroupPresentationOrderField;

        /// <remarks/>
        public ModificationDateType SpeciesGroupModificationDate
        {
            get
            {
                return speciesGroupModificationDateField;
            }
            set
            {
                speciesGroupModificationDateField = value;
            }
        }

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

        /// <remarks/>
        public string SpeciesGroupName
        {
            get
            {
                return speciesGroupNameField;
            }
            set
            {
                speciesGroupNameField = value;
            }
        }

        /// <remarks/>
        public InfoType SpeciesGroupInfo
        {
            get
            {
                return speciesGroupInfoField;
            }
            set
            {
                speciesGroupInfoField = value;
            }
        }

        /// <remarks/>
        public VersionType SpeciesGroupVersion
        {
            get
            {
                return speciesGroupVersionField;
            }
            set
            {
                speciesGroupVersionField = value;
            }
        }

        /// <remarks/>
        [XmlElement("StemTypeDefinition")]
        public StemTypeDefinitionType[] StemTypeDefinition
        {
            get
            {
                return stemTypeDefinitionField;
            }
            set
            {
                stemTypeDefinitionField = value;
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
        public string SpeciesGroupPresentationOrder
        {
            get
            {
                return speciesGroupPresentationOrderField;
            }
            set
            {
                speciesGroupPresentationOrderField = value;
            }
        }
    }

    /// <remarks/>
    [XmlInclude(typeof(SpeciesGroupDefinitionSpeciesGroupInstructionType))]
    [XmlInclude(typeof(SpeciesGroupDefinitionWithDetailsAndKeyType))]
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SpeciesGroupDefinitionWithDetailsType : CommonSpeciesGroupDefinitionType
    {

        private DBHHeightType dBHHeightField;

        private GradesType gradesField;

        private BarkFunctionType barkFunctionField;

        private SoundKnotFunctionType soundKnotFunctionField;

        private ButtEndProfileExtrapolationType buttEndProfileExtrapolationField;

        private EstonianVolumeParametersType estonianVolumeParametersField;

        private StemCodeType[] stemCodeField;

        /// <remarks/>
        public DBHHeightType DBHHeight
        {
            get
            {
                return dBHHeightField;
            }
            set
            {
                dBHHeightField = value;
            }
        }

        /// <remarks/>
        public GradesType Grades
        {
            get
            {
                return gradesField;
            }
            set
            {
                gradesField = value;
            }
        }

        /// <remarks/>
        [XmlElement(IsNullable = true)]
        public BarkFunctionType BarkFunction
        {
            get
            {
                return barkFunctionField;
            }
            set
            {
                barkFunctionField = value;
            }
        }

        /// <remarks/>
        public SoundKnotFunctionType SoundKnotFunction
        {
            get
            {
                return soundKnotFunctionField;
            }
            set
            {
                soundKnotFunctionField = value;
            }
        }

        /// <remarks/>
        public ButtEndProfileExtrapolationType ButtEndProfileExtrapolation
        {
            get
            {
                return buttEndProfileExtrapolationField;
            }
            set
            {
                buttEndProfileExtrapolationField = value;
            }
        }

        /// <remarks/>
        public EstonianVolumeParametersType EstonianVolumeParameters
        {
            get
            {
                return estonianVolumeParametersField;
            }
            set
            {
                estonianVolumeParametersField = value;
            }
        }

        /// <remarks/>
        [XmlElement("StemCode")]
        public StemCodeType[] StemCode
        {
            get
            {
                return stemCodeField;
            }
            set
            {
                stemCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SpeciesGroupDefinitionSpeciesGroupInstructionType : SpeciesGroupDefinitionWithDetailsType
    {

        private SpeciesDefinitionType[] speciesDefinitionField;

        /// <remarks/>
        [XmlElement("SpeciesDefinition")]
        public SpeciesDefinitionType[] SpeciesDefinition
        {
            get
            {
                return speciesDefinitionField;
            }
            set
            {
                speciesDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:skogforsk:stanford2010")]
    public partial class SpeciesGroupDefinitionWithDetailsAndKeyType : SpeciesGroupDefinitionWithDetailsType
    {

        private string speciesGroupKeyField;

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
}
