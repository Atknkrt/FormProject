using FormProject.Core.DataAccess;
using FormProject.Core.DataAccess.EntityFramework;
using FormProject.DataAccess.Abstract;
using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.DataAccess.Concrete.EntityFramework
{
    public class EFFormFieldDal: EFEntityRepositoryBase<FormField, WorkProjectContext>,IFormFieldDal
    {
    }
}
