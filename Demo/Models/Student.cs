using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public int DepLocatedId { get; set; }
        public virtual Department? DepLocated { get; set; }
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = null!;
    }
}
