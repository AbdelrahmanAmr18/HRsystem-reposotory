using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System_Domain.Entities
{
    public class Level
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<Employee>? Employees { get; set; }
        //public int ManagerId { get; set; }
        //public virtual Employee? Manager { get; set; }

        //public int EmployeeId { get; set; }
        //public virtual Employee? Employee { get; set; }
    }
}
