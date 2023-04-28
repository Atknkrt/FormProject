using FormProject.DataAccess.Concrete.EntityFramework.Mappings;
using FormProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormProject.DataAccess.Concrete.EntityFramework
{
    public class WorkProjectContext:DbContext
    {
        public WorkProjectContext()
        {
            Database.SetInitializer<WorkProjectContext>(null);
        }
        
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormField> FormFields { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FormMap());
            modelBuilder.Configurations.Add(new FormFieldMap());
            modelBuilder.Configurations.Add(new AdminMap());
        }
        
    }
}
