using System.ComponentModel.DataAnnotations;

namespace Hitss
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string BirthDate { get; set; }
        public string StartDate { get; set; }
       

        public virtual Company Company { get; set; }
    }
}
