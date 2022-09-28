using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("fundingcomposition")]

    public class FundingComposition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public double percentaje { get; set; }

        public int? subcategoryid { get; set; }

        public int? fundingid{ get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

    }
}
