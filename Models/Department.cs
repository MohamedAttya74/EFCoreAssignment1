using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment1.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string? Name  { get; set; }

        public string? Dept_Desc { get; set; }
        public string? Dept_Location { get; set; }
        public int Dept_Manager { get; set; }

        public DateTime Manager_hiredate { get; set; }
    }
}
