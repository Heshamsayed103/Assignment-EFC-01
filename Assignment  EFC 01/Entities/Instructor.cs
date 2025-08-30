using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__EFC_01
{
    [Table("Hamada", Schema = "dbo")]
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("InstructorName", TypeName = "nvarchar")]
        [MaxLength(100)]
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal HourRateBonus { get; set; }

        public int Dept_ID { get; set; }
    }
}
