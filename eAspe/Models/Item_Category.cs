namespace eAspe.Models
{
    public class Item_Category
    {
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public Guid CategoryId { get; set; }
        public Item Category { get; set; }

    }
}
