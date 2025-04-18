using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    [Keyless]
    internal class Course_Inst
    {
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }
}
