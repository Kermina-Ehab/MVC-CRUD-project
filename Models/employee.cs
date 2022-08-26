using System.ComponentModel.DataAnnotations.Schema;
namespace MVC_Day07.Models
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        [ForeignKey("Department")]
        public int deptid { get; set; }
        public virtual Department Department { get; set; }


    }
}
