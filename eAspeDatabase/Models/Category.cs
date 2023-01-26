using System.ComponentModel.DataAnnotations;

namespace eAspe.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [MaxLength(150)]
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Category()
        {

        }
    }
}
