using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
      public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
          : base(options)
      {
      }

      public DbSet<Cat> Cats { get; set; }
      public DbSet<Dog> Dogs { get; set; }
      
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Maddie", Traits = "noisey", Age = 3, Gender = "Female" },
          new Cat { CatId = 2, Name = "Juno", Traits = "playful", Age = 11, Gender = "Female" },
          new Cat { CatId = 3, Name = "Dano", Traits = "bossy", Age = 12, Gender = "Female" },
          new Cat { CatId = 4, Name = "Baby", Traits = "sleepy", Age = 4, Gender = "Male" },
          new Cat { CatId = 5, Name = "Lion", Traits = "feisty", Age = 8, Gender = "Male" }
        );
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Rilo", Traits = "Maddie", Age = 3, Gender = "Female" },
          new Dog { DogId = 2, Name = "Mogley", Traits = "playful", Age = 11, Gender = "Female" },
          new Dog { DogId = 3, Name = "Patricia", Traits = "bossy", Age = 12, Gender = "Female" },
          new Dog { DogId = 4, Name = "Brownie", Traits = "sleepy", Age = 4, Gender = "Male" },
          new Dog { DogId = 5, Name = "Rolf", Traits = "feisty", Age = 8, Gender = "Male" }
        );
    }
  }
}