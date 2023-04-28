using FormProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Entities.Concrete
{
    public class Admin:IEntity
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
    }
}
