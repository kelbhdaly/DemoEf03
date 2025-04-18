using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Demo.Models
{
    [PrimaryKey(nameof(StdId) , nameof(CrsId))]
    internal class StudentCourse
    {
        [ForeignKey(nameof(StdId))]
        public int StdId { get; set; }
        [ForeignKey(nameof(CrsId))]
        public int CrsId { get; set; }
        public int Grade { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
