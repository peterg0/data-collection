using System.ComponentModel.DataAnnotations;

namespace data_collection.Models
{
    public class Widget
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
    }
}
