using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Image> Images { get; set; }

        [Required]
        public List<ItemProperties> ItemProperties { get; set; }
        public List<Category> Categories { get; set; }

        [ForeignKey("Manufacturer")]
        [Required]
        public Guid ManufacturerId { get; set; }

        public Item()
        {

        }
    }
}
