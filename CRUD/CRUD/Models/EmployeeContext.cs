using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<EmployeeModel> EmployeeModels { get; set; }
        public DbSet<DepartmentModel> DepartmentModels { get; set; }
    }
}
