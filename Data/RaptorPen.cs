using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JurassicWorldWeb.Data
{
    public class RaptorPen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RID { get; set; }
        public string RName { get; set; }

        [ForeignKey("EID")]
        public int EID { get; set; }
    }
}
