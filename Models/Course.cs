using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    internal class Course
    {
        public int  CourseId { get; set; }
        public string? Name  { get; set; }
        public int Crs_Duration { get; set; } 
        public int Top_Id { get; set; }
    }
}
