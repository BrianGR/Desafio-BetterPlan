using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("investmentstrategytype")]
    public class InvestmentStrategyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string iconurl { get; set; }
        public string title { get; set; }
        public string shorttitle { get; set; }
        public string description { get; set; }
        public string recommendedfor { get; set; }
        public bool isvisible { get; set; }
        public bool isdefault { get; set; }
        public int? desplayorder { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public int? financialentityid { get; set; }

    }
}
