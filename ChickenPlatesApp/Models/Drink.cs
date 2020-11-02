using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(250)]
        public string DrinkName { get; set; }
    }
}
