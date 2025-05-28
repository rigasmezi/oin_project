using OinGenerator.Models;
using OinGenerator.Services;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ForemsWeb.Core.Api.Services.Foundations.Oin
{
    public partial class OinService : IOinService
    {
        private static string TEMPLATE_ENV = "template_rmezi.hrv.env";
        XmlDocument xmlDoc;

        ObjectInstructionType oinObject;
        ProductInstructionType pinObject;
        SpeciesGroupInstructionType spiObject;

        List<string> productIds = new();
        XmlWriterSettings settings = new XmlWriterSettings();


        public OinService()
        {
            settings.Indent = true;
        }
        public string CreateFellingOinFile(OinFelling oinFelling)
        {
            if (!string.IsNullOrWhiteSpace(oinFelling.TemplateName))
            {
                TEMPLATE_ENV = oinFelling.TemplateName;
            }
            string templatePath = Path.Combine(Directory.GetCurrentDirectory(), TEMPLATE_ENV);
            //check if template exists
            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException("Template file not found", templatePath);
            }

            ValidateOinFellingOnExport(oinFelling);

            string savedFileName = Path.Combine(Directory.GetCurrentDirectory(), $"{oinFelling.Name}.oin");

            LoadEnvFile(templatePath);

            productIds.Clear();

            bool found = false;
            List<string> notFoundProducts = new List<string>();
            foreach (var fellingProduct in oinFelling.FellingProducts)
            {
                string currentSpeciesGroupUserID = string.Empty;
                foreach (var specie in spiObject.SpeciesGroupDefinition)
                {
                    if (RemoveDiacritics(specie.SpeciesGroupUserID.Value).ToUpper() ==
                        RemoveDiacritics(fellingProduct.Specie).ToUpper())
                    {
                        currentSpeciesGroupUserID = RemoveDiacritics(specie.SpeciesGroupUserID.Value).ToUpper();
                    }
                }

                foreach (var pinProduct in pinObject.ProductDefinition)
                {
                    // Apstrāde lai tiekam vaļā no garumzīmēm/maziem burtiem
                    fellingProduct.Assortment = RemoveDiacritics(fellingProduct.Assortment).ToUpper();

                    if (RemoveDiacritics(pinProduct.Item.SpeciesGroupUserID.Value).ToUpper() == currentSpeciesGroupUserID)
                    {
                        if (RemoveDiacritics(pinProduct.Item.ProductName).ToUpper() ==
                        fellingProduct.Assortment)
                        {
                            productIds.Add(pinProduct.ProductUserID.Value);
                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    notFoundProducts.Add(currentSpeciesGroupUserID + "-" + fellingProduct.Assortment);
                }
                found = false;
            }

            ValidateNotFoundProducts(notFoundProducts);

            UpdateObjectInstruction(oinFelling);

            string path = SaveOINFile(savedFileName);

            return path;
        }



        private string SaveOINFile(string savedFileName)
        {
            if (oinObject == null)
            {
                throw new InvalidOperationException("oinObject is not loaded.");
            }

            string fullPath = savedFileName;


            XmlWriterSettings writerSettings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = Encoding.UTF8, // Encoding.GetEncoding("ISO-8859-1"),
                IndentChars = "  "
            };


            using (XmlWriter writer = XmlWriter.Create(fullPath, writerSettings))
            {

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "urn:skogforsk:stanford2010");

                XmlSerializer serializer = new XmlSerializer(typeof(ObjectInstructionType));
                serializer.Serialize(writer, oinObject, ns);
            }

            return fullPath;
        }

        private void UpdateObjectInstruction(OinFelling felling)
        {
            if (oinObject == null)
            {
                throw new InvalidOperationException("oinObject is not loaded.");
            }

            // Update basic felling information
            oinObject.ObjectDefinition.ObjectName = RemoveDiacritics(felling.Name).ToUpper();
            oinObject.ObjectDefinition.ObjectUserID = new UserIDType { agency = AgencyType.Other, agencySpecified = true, Value = RemoveDiacritics(felling.Name).ToUpper() };
            oinObject.ObjectDefinition.ObjectModificationDate = new ModificationDateType { Value = DateTime.Now };
            oinObject.ObjectDefinition.ForestCertification = new[] { ForestCertificationType.Notknown };
            oinObject.ObjectDefinition.LoggingForm = new LoggingFormType
            {
                agency = AgencyType.Other,
                LoggingFormCode = "0",
                LoggingFormDescription = RemoveDiacritics(felling.FellingType).ToUpper()
            };
            oinObject.ObjectDefinition.LoggingOrganisation = new LoggingOrganisationType
            {
                ContactInformation = new ContactInformationType { BusinessName = RemoveDiacritics(felling.LoggingOrganisation).ToUpper() },
                District = "",
                Team = "",
            };
            oinObject.ObjectDefinition.ForestOwner = new ContactInformationType { BusinessName = RemoveDiacritics(felling.ForestOwner).ToUpper() };
            oinObject.ObjectDefinition.ContractNumber = new ContractNumberType { ContractCategory = "", Value = RemoveDiacritics(felling.ContractNumber).ToUpper() };
            oinObject.ObjectDefinition.RealEstateIDObject = new RealEstateIDObjectType { agency = AgencyType.Other, Value = felling.CadastralNumber };
            oinObject.ObjectDefinition.TextToMachine = "";

            // Remove existing ProductUserID nodes
            oinObject.ObjectDefinition.ProductUserID = new List<UserIDType>().ToArray();

            // Add new ProductUserID nodes for each product ID

            var tempProductUserIds = new List<UserIDType>(oinObject.ObjectDefinition.ProductUserID);
            foreach (var productId in productIds)
            {
                tempProductUserIds.Add(new UserIDType { Value = productId, agencySpecified = true, agency = AgencyType.Other });
            }

            oinObject.ObjectDefinition.ProductUserID = tempProductUserIds.ToArray();
        }

        private void LoadEnvFile(string fileName)
        {
            try
            {
                // Load the XML file
                this.xmlDoc = new XmlDocument();
                xmlDoc.Load(fileName);

                // Set up namespace manager to handle namespaces in XML
                XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                nsManager.AddNamespace("stanford", "urn:skogforsk:stanford2010");

                // Get the StanForD2010Message node
                XmlNodeList nodes = xmlDoc.SelectNodes("//stanford:StanForD2010Message", nsManager);

                foreach (XmlNode node in nodes)
                {
                    XmlNode embeddedDocumentNode = node.SelectSingleNode("./stanford:MessageDocument/stanford:EmbeddedDocument", nsManager);

                    // Check if EmbeddedDocument node exists
                    if (embeddedDocumentNode != null)
                    {
                        // Get the content of the EmbeddedDocument
                        string embeddedDocumentContent = embeddedDocumentNode.InnerText;

                        if (embeddedDocumentNode.ParentNode.ParentNode.Attributes["messageCategory"].Value.ToLower() == "oin")
                        {

                            var serializer = new XmlSerializer(typeof(ObjectInstructionType));
                            using (var stream = new StringReader(embeddedDocumentContent))
                            using (var reader = XmlReader.Create(stream))
                            {
                                oinObject = (ObjectInstructionType)serializer.Deserialize(reader);
                            }
                        }

                        if (embeddedDocumentNode.ParentNode.ParentNode.Attributes["messageCategory"].Value.ToLower() == "spi")
                        {
                            var serializer = new XmlSerializer(typeof(SpeciesGroupInstructionType));
                            using (var stream = new StringReader(embeddedDocumentNode.InnerText))
                            using (var reader = XmlReader.Create(stream))
                            {
                                spiObject = (SpeciesGroupInstructionType)serializer.Deserialize(reader);
                            }
                        }

                        if (embeddedDocumentNode.ParentNode.ParentNode.Attributes["messageCategory"].Value.ToLower() == "pin")
                        {
                            var serializer = new XmlSerializer(typeof(ProductInstructionType));
                            using (var stream = new StringReader(embeddedDocumentNode.InnerText))
                            using (var reader = XmlReader.Create(stream))
                            {
                                pinObject = (ProductInstructionType)serializer.Deserialize(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static string RemoveDiacritics(string text)
        {
            if (text is null)
            {
                return string.Empty;
            }

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
