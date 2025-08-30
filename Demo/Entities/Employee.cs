﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Entities
{

    // EF Core Support 4 Ways For Mapping Classes in DataBase : [Table , View , Function]
    // 1. By Cinvention [Default Behaviour]
    // 2. Data Annotation [Set Of Attributes Used For Data Validation]
    // 3. Fluent APIs
    // 4. Class Configration



    //// Entity
    //// Poco :
    //// Plain OLD CLR Object
    //internal class Employee // Table 
    //{
    //    public int Id { get; set; }  // Public Numeric Property Named 'Id' | EmployeeId --> PK 
    //    public string Name { get; set; } // Reference Type :  Requarid [Not Allow Null] - nvarchar(Max)
    //    public int Age { get; set; } // Value Type : int [Age] - Required
    //    public double Salary { get; set; } // Value Type : float [salary] - Required
    //    public string Email { get; set; } // nvarchar(Max) - optional
    //    public DateTime DataOfCreation { get; set; } // datatime2- Required



    //}


    //// 2. Data Annotation
    //[Table("Hamda", Schema = "dbo")]
    //class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }

    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }


    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }


    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //    public string Password { get; set; }



    //}



    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }



}
