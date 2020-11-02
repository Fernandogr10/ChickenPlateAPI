using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChickenPlatesApp.Models
{
    public class ChickenPart
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string PartName { get; set; }
    }
}
