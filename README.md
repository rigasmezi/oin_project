# OinGenerator

OinGenerator is a .NET 9 console application for generating OIN (Object Instruction) files based on forestry felling data. It reads structured input from a JSON file, validates the data, and produces an OIN file using a specified XML template. 
The application is designed to support forestry workflows, such as logging operations, by automating the creation of standardized instruction files.
You can have multiple templates for different types of felling operations, and the application will handle the generation based on the provided template name in the input file.

## How to run project

1. Ensure you have .NET 9 SDK installed on your machine.
2. Clone the repository or download the source code.
3. Open a terminal and navigate to the project directory OinGenerator.
4. dotnet build
5. dotnet run


## Features

- Reads felling data from `input.json`
- Validates input and template existence
- Handles and reports validation errors with detailed messages
- Generates OIN files using XML templates
- Supports extensible product and species definitions

## Usage

1. Place your `input.json` and template file (e.g., `template_rmezi.hrv.env`) in the application directory.
2. Run the application. The output OIN file will be saved in the same directory.
3. Easily integrated. Can be used with another applications that generate input.json and reads the generated OIN file. 

## Error Handling

- If the input file or template is missing or empty, the application will report the issue and exit.
- Validation errors are reported with detailed messages, including all issues found in the input.


## `input.json` Structure

The `input.json` file must contain the following structure:
### Field Descriptions

- **TemplateName**: (string) Name of the XML template file to use for OIN generation.
- **Name**: (string) Unique identifier for the felling operation.
- **FellingType**: (string) Type of felling (e.g., "Galvenā vienlaidus cirte").
- **Owner**: (string) Name of the forest owner.
- **CadastralNumber**: (string) Cadastral number of the property.
- **LoggingOrganisation**: (string) Name of the logging organization.
- **ContractNumber**: (string) Contract number for the operation.
- **FellingProducts**: (array) List of products, each with:
  - **Specie**: (string) Species name.
  - **Assortment**: (string) Product assortment.

