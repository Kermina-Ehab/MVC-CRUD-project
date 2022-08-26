using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Day07.Models
{
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string Deptname { get; set; }
        public virtual ICollection<employee> emps { get; set; }



    }
}
