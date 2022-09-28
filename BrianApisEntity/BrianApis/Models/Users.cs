using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{


    [Table("user")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string firstname { get; set; }

        public string surname { get; set; }

        public int? advisorid { get; set; }

        public int? currencyid { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

    }
}

