using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("financialentity")]

    public class FinancialEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string logo { get; set; }

        public string title { get; set; }

        public string uuid { get; set; }

        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string description { get; set; }
        public int? defaultcurrencyid { get; set; }
    }
}
