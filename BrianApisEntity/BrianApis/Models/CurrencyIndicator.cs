using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("currencyindicator")]

    public class CurrencyIndicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int sourcecurrencyid { get; set; }

        public int destinationcurrencyid { get; set; }

        public double value { get; set; }

        public DateTime date { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }
        public DateTime requestdate { get; set; }

        public double ask { get; set; }

        public double bid { get; set; }
    }
}
