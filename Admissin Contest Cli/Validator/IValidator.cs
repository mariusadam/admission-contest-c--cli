using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Validator
{
    interface IValidator<T>
    {
        void validate(T entity);
    }
}
