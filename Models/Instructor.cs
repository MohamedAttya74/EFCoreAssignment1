using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }

        [Required]
        [Column("Ins_Name", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string?  Name  { get; set; }
        [Required]
        [Column("Ins_Degree", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Ins_Degree { get; set; }

        [Column("Ins_Salary", TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }


    }
}
