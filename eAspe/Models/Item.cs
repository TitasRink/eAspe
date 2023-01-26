using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Pavadinimas")]
        public string Title { get; set; }

        [Display(Name = "Aprašymas")]
        public string Content { get; set; }
        public List<Image> Images { get; set; }

        [Required]
        public List<ItemProperties> ItemProperties { get; set; }
        public List<Item_Category> Items_Categories { get; set; }



        [ForeignKey("Manufacturer")]
        [Required(ErrorMessage = "Manufacturer is required")]
        public Guid ManufacturerId { get; set; }
    }
}
