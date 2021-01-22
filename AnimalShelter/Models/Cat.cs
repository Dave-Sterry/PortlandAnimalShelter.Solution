using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Age must be between 1-30")]
        public int Age { get; set; }
    }
}