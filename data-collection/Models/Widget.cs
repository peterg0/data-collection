using System.ComponentModel.DataAnnotations;

namespace data_collection.Models
{
    public class Widget
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the Widget Name.")]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Type { get; set; }
        public string SubType { get; set; }
    }
}
