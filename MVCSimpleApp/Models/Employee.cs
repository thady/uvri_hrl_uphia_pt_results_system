using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity; // refference for Entity framework
using System.ComponentModel.DataAnnotations;

namespace MVCSimpleApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)] //max and minimum length
        public string Name { get; set; }

        [Display(Name = "Joining Date")] //set the display name
        [DataType(DataType.Date)] //data type 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }

        [Range(22, 60)] //data annotations---validation..age shd be between 22 and 60
        public int age { get; set;}
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}