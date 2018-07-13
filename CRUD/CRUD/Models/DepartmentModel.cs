using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
