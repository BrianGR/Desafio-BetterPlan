using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("portafoliofunding")]
    public class PortafolioFunding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public double porcentage { get; set; }

        public int fundingid { get; set; }

        public int portafolioid { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

   

    }
}
