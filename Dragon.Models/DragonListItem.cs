using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Models
{
    public class DragonListItem
    {
        public int DragonId { get; set; }
        public string DragonName { get; set; }
        [Display(Name="Creation of dragon")]
        public DateTimeOffset BirthOfDragon { get; set; }

        public string DragonColor { get; set; }
        public string DragonDescription { get; set; }

    }
}
