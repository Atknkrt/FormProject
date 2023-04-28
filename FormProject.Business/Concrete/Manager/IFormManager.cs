using FormProject.Business.Abstract;
using FormProject.DataAccess.Abstract;
using FormProject.Entities.Concrete;
using FormProject.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using FormProject.Core.Aspects.Postsharp.ValidationAspect;

namespace FormProject.Business.Concrete.Manager
{
    public class IFormManager : IFormService
    {
        private IFormDal _formDal;

        public IFormManager(IFormDal formDal)
        {
            _formDal = formDal;
        }
        [FluentValidationAspect(typeof(FormValidatior))]
        public Form Add(Form form)
        {
            return _formDal.Add(form);
        }
        
        public List<Form> GetAll()
        {
            return new List<Form>();
        }
        
        public Form GetByName(string name)
        {
            return _formDal.Get(p=>p.name== name);
        }
    }
}
