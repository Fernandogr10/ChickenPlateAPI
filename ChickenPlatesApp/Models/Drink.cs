using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string DrinkName { get; set; }
        public ChickenPlate ChickenPlate { get; set; }
        public long ChickenPlateId { get; set; }
    }
}
