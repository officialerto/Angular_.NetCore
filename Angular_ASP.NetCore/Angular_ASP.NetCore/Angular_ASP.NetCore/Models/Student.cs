using System.ComponentModel.DataAnnotations;

namespace Angular_ASP.NetCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
}
