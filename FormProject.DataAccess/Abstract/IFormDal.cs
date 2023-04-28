using FormProject.Core.DataAccess;
using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.DataAccess.Abstract
{
    public interface IFormDal:IEntityRepository<Form>
    {
    }
}
