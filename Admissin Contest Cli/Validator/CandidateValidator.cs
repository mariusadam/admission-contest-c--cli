using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Validator
{
    class CandidateValidator : EntityValidator<Candidate>
    {
        public override void validate(Candidate entity)
        {
            base.validate(entity);

            if (entity.Name.Length < 5)
            {
                errors.Add("Name must have at least 5 characters.");
            }
            if (entity.Address.Length == 0)
            {
                errors.Add("Address is required.");
            }
            if (entity.Phone.Length == 0)
            {
                errors.Add("Phone is required.");
            }

            checkErrors();
        }
    }
}
