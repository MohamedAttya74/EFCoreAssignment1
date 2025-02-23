using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Fname", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Fname  { get; set; }
        [Required]
        [Column("Lname", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Lname  { get; set; }
        [Required]
        [Column("Address", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Address  { get; set; }

        [AllowedValues(25, 28, 30, 40)]  
        [DeniedValues(20, 22, 21, 55)]
        public int Age  { get; set; }

        [Column("Super")]
        public int Super  { get; set; }
    }
}
