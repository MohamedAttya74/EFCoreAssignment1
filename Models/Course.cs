using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    [Table("Courses")]
    internal class Course
    {
        [Key]
        public int  CourseId { get; set; }

        [Required]
        [Column("Crs_Name",TypeName ="varchar")]
        [StringLength(50, MinimumLength = 3)] 
        public string? Name  { get; set; }

        [Column("Course_Duration")]
        public int Crs_Duration { get; set; }
        [Column("Top_Id")]
        public int Top_Id { get; set; }
    }
}
