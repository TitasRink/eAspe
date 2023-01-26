using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public Image Image { get; set; }

        
        [ForeignKey("Item")]
        [Required(ErrorMessage = "Item is required")]
        public Guid ItemID { get; set; }
    }
}
