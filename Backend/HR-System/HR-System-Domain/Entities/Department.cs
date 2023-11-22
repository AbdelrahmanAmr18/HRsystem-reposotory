using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System_Domain.Entities
{
    public class Department
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string CurrentAddress { get; set; } = string.Empty;
        public string PerminentAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public int? CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
        //public int CompanyId { get; set; }

        //[ForeignKey("CompanyId")]
        //public virtual Company? Company { get; set; }

        //public int EmployeeId { get; set; }

        //[ForeignKey("EmployeeId")]
        //public virtual Employee? Employee { get; set; }
    }
}
