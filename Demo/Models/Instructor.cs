using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public float Bonus { get; set; }

        public virtual Department? ManagedDepartment { get; set; }

        public virtual Department WorkingDepartment { get; set; }

        public int WorkingDepartmentId { get; set; }


    }
}
