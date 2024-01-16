using System.ComponentModel.DataAnnotations;

namespace Lab_2.Models
{
    public class Item
    {
            public int Id { get; set; }
            [Required]
            public string? Title { get; set; }
            [Required]
            public int Price { get; set; }
            public string? Description { get; set; }
            public string? Manufacturer { get; set; }
    }
}
