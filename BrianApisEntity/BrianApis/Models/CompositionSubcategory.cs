using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("compositionsubcategory")]
    public class CompositionSubcategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }

        public string uuid { get; set; }

        public string description { get; set; }

        public int? categoryid { get; set; }

        public DateTime created { get; set; }

    }
}
