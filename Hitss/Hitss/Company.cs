using System.ComponentModel.DataAnnotations;

namespace Hitss
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }  
    }
}
