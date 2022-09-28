using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BrianApis.Models
{
    [Table("currency")]

    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string name { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public string uuid { get; set; }
        public string yahoomnemonic { get; set; }
        public string currencycode { get; set; }
        public string digitsinfo { get; set; }
        public string display { get; set; }
        public string locale { get; set; }
        public string serverformatnumber { get; set; }


    }
}
