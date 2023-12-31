﻿using System.ComponentModel.DataAnnotations;

namespace data_collection.Models
{
    public class Widget
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the Widget Name.")]
        [Display(Name = "Widget Name")]
        public string Name { get; set; }
        [Display(Name = "Date Created")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string Type { get; set; }
        [Display(Name = "Widget Sub-Type")]
        public string SubType { get; set; }
    }
}
