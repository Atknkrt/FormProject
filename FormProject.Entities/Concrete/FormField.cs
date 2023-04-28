using FormProject.Core.Entities;
using FormProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Entities.Concrete
{
    public class FormField:IEntity
    {
        public int id { get; set; }
        public int formId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
    }
}
