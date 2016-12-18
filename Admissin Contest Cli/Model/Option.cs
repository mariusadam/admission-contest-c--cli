using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Model
{
    public class Option : Entity<int>
    {
        public Candidate Candidate { get; set; }
        public Department Department { get; set; }

        public Option(int id, Candidate candidate, Department department) : base(id)
        {
            Candidate  = candidate;
            Department = department;
        }
    }
}
