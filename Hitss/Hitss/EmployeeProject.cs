using System.ComponentModel.DataAnnotations;

namespace Hitss
{
    public class EmployeeProject
    {
        [Key]
        public int Id { get; set; }
        

        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Cat_Role Cat_Role { get; set; }

    }
}
