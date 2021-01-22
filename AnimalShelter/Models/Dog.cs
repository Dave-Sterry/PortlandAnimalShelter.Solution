using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}