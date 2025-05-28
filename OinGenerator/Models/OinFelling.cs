namespace OinGenerator.Models
{
    public class OinFelling
    {
        /// <summary>
        /// Name of the env template to use
        /// </summary>
        public string TemplateName { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Cirtes izpildes veids piemēram IZLASES VEIDA CIRTE
        /// </summary>
        public string FellingType { get; set; }
        public string LoggingOrganisation { get; set; }
        public string ForestOwner { get; set; }
        /// <summary>
        /// "SRM-XX-XX" 
        /// </summary>
        public string ContractNumber { get; set; }
        public string CadastralNumber { get; set; }

        public List<OinFellingProduct> FellingProducts { get; set; } = new();
    }
}
