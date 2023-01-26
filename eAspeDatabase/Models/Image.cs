using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Image
    {
        public Guid Id { get; set; }

        [Required]
        public string LogoURL { get; set; }

        public Guid? ItemID { get; set; }
        public Guid? ManufacturerID { get; set; }

        public Image()
        {

        }
    }
}
