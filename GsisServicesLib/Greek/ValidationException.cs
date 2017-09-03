using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsisServicesLib.Greek
{
    public class ValidationException : Exception
    {

        public ValidationException(List<string> validationErrors) : base() {
            ValidationErrors = validationErrors;
        }

        public ValidationException(string message, List<string> validationErrors) : base(message) { ValidationErrors = validationErrors; }

        public ValidationException(string message, System.Exception inner, List<string> validationErrors) : base(message, inner) { ValidationErrors = validationErrors; }

        public List<string> ValidationErrors { get; private set; }

    }
}
