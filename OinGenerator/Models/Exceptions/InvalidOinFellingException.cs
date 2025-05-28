using System.Collections;
using Xeptions;

namespace OinGenerator.Models.Exceptions
{
    public class InvalidOinFellingException : Xeption
    {
        public InvalidOinFellingException()
          : base(message: "Invalid OinFelling. Please correct the errors and try again.")
        { }

        public InvalidOinFellingException(Exception innerException, IDictionary data)
            : base(message: "Invalid OinFelling error occurred. please correct the errors and try again.", innerException, data)
        { }
    }
}
