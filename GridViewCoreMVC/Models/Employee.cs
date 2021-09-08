using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GridViewCoreMVC.Models
{
    public class Employee
    {
        
        [Key] // indicate EF that this is key of table, as it doesn't have usualy "Id" column as PK
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
    }
}

