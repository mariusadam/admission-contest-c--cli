using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Validator
{
    class ValidatorException : Exception
    {
        public ValidatorException(string msg) : base(msg)
        {

        }
    }
}
