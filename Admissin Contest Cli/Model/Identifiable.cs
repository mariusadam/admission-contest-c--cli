using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Model
{
    public interface Identifiable<IdType>
    {
        IdType Id { get; }
    }
}
