using ChickenPlatesApp.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class ChickenPlate
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(250)]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Sauce { get; set; }
        public decimal ChickenAmount { get; set; }
        public ChickenType Type { get; set; }
        public ChickenPart part { get; set; }
        public SideDish Dish { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
