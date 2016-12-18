using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Model
{
    public abstract class Entity<IdType> : Identifiable<IdType>
    {
        public IdType Id { get; }

        public Entity(IdType id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return "Id: " + Id;
        }

        public override bool Equals(object obj)
        {
            return obj is Entity<IdType> && Id.Equals((obj as Entity<IdType>).Id);
        }
    }
}
