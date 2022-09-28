using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("portfoliocomposition")]
    public class PortafolioComposition
    {
        public int? id { get; set; }
        public double porcentage { get; set; }
        public int? subcategoryid { get; set; }
        public int? portfolioid { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }

    }
}
