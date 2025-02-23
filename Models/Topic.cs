using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    [Table("Topices")]
    internal class Topic
    {
        [Key]
        public int Top_Id { get; set; }
        [Required]
        [Column("Top_Name", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? Top_Name { get; set; }
    }
}
