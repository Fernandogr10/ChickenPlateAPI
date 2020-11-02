using System.ComponentModel.DataAnnotations;

namespace ChickenPlatesApp.Models
{
    public class ChickenPart
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(250)]
        public string PartName { get; set; }
    }
}
