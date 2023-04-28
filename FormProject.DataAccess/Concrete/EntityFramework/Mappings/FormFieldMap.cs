using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class FormFieldMap: EntityTypeConfiguration<FormField>
    {
        public FormFieldMap()
        {
            ToTable(@"FormFields", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.formId).HasColumnName("formId");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");
            Property(x => x.Age).HasColumnName("Age");
        }
    }
}
