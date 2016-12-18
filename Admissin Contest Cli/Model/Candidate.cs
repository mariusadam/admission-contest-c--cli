using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Model
{
    public class Candidate : Entity<int>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Candidate(int id, string name, string phone, string address) : base(id)
        {
            Name    = name;
            Phone   = phone;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Name: {0}, Phone: {1}, Address: {2}", Name, Phone, Address);
        }
    }
}
