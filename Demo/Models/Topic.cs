using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> CourseTopic { get; set; } = new HashSet<Course>();
    }
}
