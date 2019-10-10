using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JurassicWorldWeb.Data
{
    public class HerbivorePen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HID { get; set; }
        public string HName { get; set; }

        [ForeignKey("EID")]
        public int EID { get; set; }
    }
}
