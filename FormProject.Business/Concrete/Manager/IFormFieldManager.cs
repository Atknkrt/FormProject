using FormProject.Business.Abstract;
using FormProject.Business.ValidationRules.FluentValidation;
using FormProject.Core.Aspects.Postsharp.ValidationAspect;
using FormProject.DataAccess.Abstract;
using FormProject.Entities.Concrete;
using FormProject.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Business.Concrete.Manager
{
    public class IFormFieldManager : IFormFieldService
    {
        private IFormFieldDal _formFieldDal;

        public IFormFieldManager(IFormFieldDal formFieldDal)
        {
            _formFieldDal = formFieldDal;
        }
        [FluentValidationAspect(typeof(FormFieldValidatior))]
        public FormField Add(FormField formField)
        {
            return _formFieldDal.Add(formField);
        }

        public List<FormField> GetAll()
        {
            return new List<FormField>();
        }

        public FormField GetByName(string name)
        {
            return _formFieldDal.Get(p=>p.Name == name);
        }
    }
}
