using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options):base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cat>()
                .HasData(
                    new Cat { CatId = 1, Name = "Neptune", Age = 3},
                    new Cat { CatId = 2, Name = "Rosie", Age = 12},
                    new Cat { CatId = 3, Name = "Socks", Age = 7},
                    new Cat { CatId = 4, Name = "Duncan", Age = 8},
                    new Cat { CatId = 5, Name = "Midnight", Age = 4}
                );

            builder.Entity<Dog>()
                .HasData(
                    new Dog { DogId = 1, Name = "Helo", Age = 8},
                    new Dog { DogId = 2, Name = "Kiva", Age = 11},
                    new Dog { DogId = 3, Name = "Jasper", Age = 12},
                    new Dog { DogId = 4, Name = "Yates", Age = 3}, 
                    new Dog { DogId = 5, Name = "Nico", Age = 5}
                );
        }
    }
}