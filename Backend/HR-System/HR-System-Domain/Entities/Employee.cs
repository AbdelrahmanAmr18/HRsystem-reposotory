using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HR_System_Domain.Entities
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(350)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public int Age { get; set; }

        [Required]
       
        public char Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string CurrentAddress { get; set; } = string.Empty;
        public string PerminentAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string EmargancyContact { get; set;} = string.Empty;
        public decimal GrossSalary { get; set; }
        public decimal Tax { get; set; }
        public decimal NetSalary { get; set; }
        public decimal Apprasial { get; set; }
        public decimal Deduction { get; set; }
        public string Education { get; set; } = string.Empty;
        public string Certificates { get; set; } = string.Empty;
        public string WorkExperience { get; set; } = string.Empty;
        public string skills { get; set; } = string.Empty;

        [ForeignKey(nameof(Company))]
        public int? CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        [ForeignKey(nameof(Branch))]
        public int? BranchId { get; set; }
        public virtual Branch? Branch { get; set; }
        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        [ForeignKey(nameof(Position))]

        public int? PositionId { get; set; }
        public Position? Position { get; set; }
        //[ForeignKey("Level")]
        [ForeignKey(nameof(Level))]
        public int? LevelId { get; set; }
        public Level? Level { get; set; }

        /*one to one relationship*/
        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        public virtual Employee? Manager { get; set; }








    }
}
