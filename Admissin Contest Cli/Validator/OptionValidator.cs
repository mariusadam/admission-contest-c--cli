using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Validator
{
    class OptionValidator : EntityValidator<Option>
    {
        public override void validate(Option entity)
        {
            base.validate(entity);

            if (entity.Candidate == null)
            {
                errors.Add("Candidate is required.");
            }
            if (entity.Department == null)
            {
                errors.Add("Department is required.");
            }

            checkErrors();
        }
    }
}
