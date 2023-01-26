using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class ItemProperties
    {
        public Guid Id { get; set; }

        [Display(Name = "Išmatavimas")]
        public string Measure { get; set; }


        [Display(Name = "Pakuotė")]
        public string Packing { get; set; }


        [Display(Name = "Vienetas")]
        [Required(ErrorMessage = "Value is required")]
        public string Value { get; set; }

        [Display(Name = "Tipas")]
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }


       
        [ForeignKey("Item")]
        [Required(ErrorMessage = "Item is required")]
        public Item ItemID { get; set; }
    }
}
