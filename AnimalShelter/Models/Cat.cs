using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}