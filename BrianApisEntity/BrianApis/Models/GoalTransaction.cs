using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("goaltransaction")]

    public class GoalTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string type { get; set; }

        public double amount { get; set; }

        public DateTime date { get; set; }

        public int? goalid { get; set; }

        public int? ownerid { get; set; }

        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public bool isprocessed { get; set; }
        public bool all { get; set; }

        public string state { get; set; }
        public int? financialentityid { get; set; }
        public int? fundingid { get; set; }
        public int? currencyid { get; set; }

        public double cost { get; set; }
    }
}
