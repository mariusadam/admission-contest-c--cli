using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Model
{
    public class Department : Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int    NumberOfSeats { get; set; }

        public Department(int id, string code, string name, int numberOfSeats) : base(id)
        {
            Code          = code;
            Name          = name;
            NumberOfSeats = numberOfSeats;
        }
    }
}
