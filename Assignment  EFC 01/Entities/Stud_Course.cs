using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__EFC_01
{
    public class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }
    }
}
