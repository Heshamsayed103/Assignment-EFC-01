using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__EFC_01
{
    internal class Course_Inst
    {
        [Key]
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }

    }
}
