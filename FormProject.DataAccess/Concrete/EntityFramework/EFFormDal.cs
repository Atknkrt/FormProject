using FormProject.Core.DataAccess.EntityFramework;
using FormProject.DataAccess.Abstract;
using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FormProject.DataAccess.Concrete.EntityFramework
{
    public class EFFormDal:EFEntityRepositoryBase<Form,WorkProjectContext>,IFormDal
    {
        
    }
}
