using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Data
{
    public class DragonEntity
    {
        [Key]
        public int DragonId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        [Display(Name = "Your Dragon")]
        public string DragonName { get; set; }
        [Required]
        public string DragonColor { get; set; }
        [Required]
        public string DragonDescription { get; set; }
        [Required]
        public DateTimeOffset BirthOfDragon { get; set; }
        public DateTimeOffset ModificationOfDragon { get; set; }
    }
}
