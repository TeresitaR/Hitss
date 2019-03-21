using System.ComponentModel.DataAnnotations;

namespace Hitss
{
    public class Cat_Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
