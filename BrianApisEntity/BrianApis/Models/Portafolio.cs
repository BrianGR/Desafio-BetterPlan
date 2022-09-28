using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("portfolio")]
    public class Portafolio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public double maxrangeyear { get; set; }

        public double minrangeyear { get; set; }

        public string uuid { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public int financialentityid { get; set; }
        public int risklevelid { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public bool isdefault { get; set; }
        public string json { get; set; }
        public int investmentstrategyid { get; set; }
        public string version { get; set; }

        public string extraprofitabilitycurrencycode { get; set; }
        public double estimatedprofitability { get; set; }
        public double bpcomission { get; set; }
    }

}
