using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Business.Abstract
{
    public interface IFormFieldService
    {
        List<FormField> GetAll();
        FormField GetByName(string name);
        FormField Add(FormField form);
    }
}
