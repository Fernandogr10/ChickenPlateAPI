using ChickenPlatesApp.Models.Enums;
using System.Collections.Generic;

namespace ChickenPlatesApp.Models
{
    public class ChickenPlate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Sauce { get; set; }
        public decimal ChickenAmount { get; set; }
        public ChickenType Type { get; set; }
        public ChickenPart part { get; set; }
        public SideDish Dish { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
