using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        [Required]
        public string Logo { get; set; }

        public Guid? ItemID { get; set; }
        public Guid? ManufacturerID { get; set; }
    }
}
