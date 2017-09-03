using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsisServicesLib.Greek
{
    public class GreekLegalEntityServiceException : Exception
    {

        public GreekLegalEntityServiceException() : base() { }

        public GreekLegalEntityServiceException(string message) : base(message) { }

        public GreekLegalEntityServiceException(string message, System.Exception inner) : base(message, inner) { }


   
    }
}
