using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admission_Contest_Cli.Model;

namespace Admission_Contest_Cli.Validator
{
    abstract class EntityValidator <T> where T : Identifiable<int>
    {
        protected List<string> errors;

        public EntityValidator()
        {
            this.errors = new List<string>();
        }

        public virtual void validate(T entity)
        {
            this.errors.Clear();

            if (entity.Id <= 0)
            {
                errors.Add("Id must be a positive integer");
            }
        }

        protected virtual void checkErrors()
        {   
            if (this.errors.Count > 0)
            {
                throw new ValidatorException(String.Join(Environment.NewLine, errors));
            }
        }
    }
}
