using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string Name { get; set; }
       
        public int? ManagerId { get; set; }
        public virtual Instructor Manager { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public virtual ICollection<Student> StuLocated { get; set; } = new HashSet<Student>();
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
