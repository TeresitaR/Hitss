using System.ComponentModel.DataAnnotations;

namespace Hitss
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       

        public virtual Company Company { get; set; }
    }
}
