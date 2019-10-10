using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JurassicWorldWeb.Data
{
    public class CeratosaurusPen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }
        public string CName { get; set; }

        [ForeignKey("EID")]
        public int EID { get; set; }
    }
}
