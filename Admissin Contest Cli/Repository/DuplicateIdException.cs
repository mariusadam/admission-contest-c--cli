using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Repository
{
    public class DuplicateIdException : Exception
    {
        public DuplicateIdException(string msg) : base(msg)
        {

        }
    }
}
