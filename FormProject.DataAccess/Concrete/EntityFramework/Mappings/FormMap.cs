using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class FormMap: EntityTypeConfiguration<Form>
    {
        public FormMap()
        {
            ToTable(@"Forms", @"dbo");
            HasKey(x => x.id);

            Property(x => x.id).HasColumnName("id");
            Property(x => x.name).HasColumnName("name");
            Property(x => x.description).HasColumnName("description");
            Property(x => x.createdAt).HasColumnName("createdAt");
            Property(x => x.createdBy).HasColumnName("createdBy");
        }
    }
}
