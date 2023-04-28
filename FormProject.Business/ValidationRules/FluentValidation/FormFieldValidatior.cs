using FluentValidation;
using FluentValidation.Validators;
using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Business.ValidationRules.FluentValidation
{
    public class FormFieldValidatior: AbstractValidator<FormField>
    {
        public FormFieldValidatior()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Surname).NotEmpty();
        }
    }
}
