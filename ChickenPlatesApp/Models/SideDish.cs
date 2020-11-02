using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class SideDish
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(250)]
        public string DishName { get; set; }
    }
}
