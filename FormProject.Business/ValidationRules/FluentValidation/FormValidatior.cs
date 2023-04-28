using FormProject.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.ValidationRules.FluentValidation
{
    public class FormValidatior : AbstractValidator<Form>
    {
        public FormValidatior()
        {
            RuleFor(p => p.name).NotEmpty();
            RuleFor(p=>p.description).NotEmpty();
            RuleFor(p => p.createdAt).NotEmpty();
            RuleFor(p=>p.createdBy).NotEmpty();
            
        }
    }
}
