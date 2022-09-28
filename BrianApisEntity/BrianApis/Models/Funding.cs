using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("funding")]

    public class Funding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string uuid { get; set; }

        public int? financialentityid { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }
        public string  mnemonic { get; set; }
        public bool isbox { get; set; }
        public string yahoomnemonic { get; set; }
        public string cmfurl { get; set; }
        public int? currencyid { get; set; }
        public bool  hassharevalue { get; set; }

    }
}
