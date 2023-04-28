﻿using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.Business.Abstract
{
    public interface IFormService
    {
        List<Form> GetAll();
        Form GetByName(string name);
        Form Add(Form form);
    }
}
