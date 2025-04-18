using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    [PrimaryKey(nameof(EmpId))]
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public int? DepartmentId { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Address EmpAddress { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }
    }
}
