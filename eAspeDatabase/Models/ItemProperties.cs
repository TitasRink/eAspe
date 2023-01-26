using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class ItemProperties
    {
        public Guid Id { get; set; }
        public string Measure { get; set; }
        public string Packing { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public string Type { get; set; }

        [ForeignKey("Item")]
        [Required]
        public Item ItemID { get; set; }

        public ItemProperties()
        {

        }
    }
}
