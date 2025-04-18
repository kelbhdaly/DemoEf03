using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public int TopicsId { get; set; }
        public virtual Topic Topics { get; set; } = null!;

        //public ICollection<Student> Students { get; set; } = null!;
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
