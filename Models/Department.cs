using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    [Table("Departments")]
    internal class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [Column("Dept_Name", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Name  { get; set; }

        [Required]
        [Column("Dept_Desc", TypeName = "varchar")]
        [StringLength(100, MinimumLength = 3)]
        public string? Dept_Desc { get; set; }

        [Required]
        [Column("Dept_Location", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Dept_Location { get; set; }

        [Column("Department_Manger")]
        public int Dept_Manager { get; set; }

        [DataType(DataType.Date)]
        public DateTime Manager_hiredate { get; set; }
    }
}
