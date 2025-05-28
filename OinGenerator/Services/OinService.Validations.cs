using OinGenerator.Models;
using OinGenerator.Models.Exceptions;

namespace ForemsWeb.Core.Api.Services.Foundations.Oin
{
    public partial class OinService
    {
        private static void ValidateOinFellingOnExport(OinFelling oinFelling)
        {
            Validate(
                (Rule: IsInvalid(oinFelling.FellingType), Parameter: nameof(OinFelling.FellingType)),
                (Rule: IsInvalid(oinFelling.ContractNumber), Parameter: nameof(OinFelling.ContractNumber)),
                (Rule: IsInvalid(oinFelling.Name), Parameter: nameof(OinFelling.Name)));
        }

        private void ValidateNotFoundProducts(List<string> notFoundProducts)
        {
            if (notFoundProducts.Count > 0)
            {
                const string FellingProducts = nameof(FellingProducts);

                var invalidOinFellingException = new InvalidOinFellingException();

                invalidOinFellingException.UpsertDataList(
                    key: FellingProducts,
                    value: $"The following products could not be found: {string.Join(", ", notFoundProducts)}");

                invalidOinFellingException.ThrowIfContainsErrors();
            }
        }

        private static dynamic IsInvalid(string text) => new
        {
            Condition = string.IsNullOrWhiteSpace(text),
            Message = "Text is required"
        };

        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidOinFellingException = new InvalidOinFellingException();

            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    invalidOinFellingException.UpsertDataList(
                        key: parameter,
                        value: rule.Message);
                }
            }

            invalidOinFellingException.ThrowIfContainsErrors();
        }
    }
}
