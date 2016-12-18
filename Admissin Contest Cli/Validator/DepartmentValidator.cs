using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Validator
{
    class DepartmentValidator : EntityValidator<Department>
    {
        public override void validate(Department entity)
        {
            base.validate(entity);

            if (entity.Name.Length < 5)
            {
                errors.Add("Name must have at least 5 characters.");
            }
            if (entity.Code.Length == 0)
            {
                errors.Add("Code is required.");
            }
            if (entity.NumberOfSeats <= 0)
            {
                errors.Add("Number of seats must be a positive integer.");
            }

            checkErrors();
        }
    }
}
