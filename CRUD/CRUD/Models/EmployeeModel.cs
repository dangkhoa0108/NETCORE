using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
    }
}
