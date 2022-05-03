using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_migration_dotnet1.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(): base("Data Source=CHETUIWK1860\\SQLEXPRESS;Initial Catalog=EmpDB;Integrated Security=True;Pooling=False") { }

        public DbSet<Employee>Employees { get; set; }
    }
}