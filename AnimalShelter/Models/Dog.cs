using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Dog
  {
    public int DogId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    public string Traits { get; set; }
    [Required]
    [Range(0, 35, ErrorMessage = "Age must be between 0 and 35.")]
    public int Age { get; set; }
    public string Gender { get; set; }
  }
}