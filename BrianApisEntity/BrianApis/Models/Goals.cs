using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{


    [Table("goal")]
    public class Goal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public string title { get; set; }
        public int? years { get; set; }
        public int? initialinvestment { get; set; }
        public int? monthlycontribution { get; set; }
        public int? targetamount { get; set; }
        public int? userid { get; set; }
        public int? goalcategoryid { get; set; }
        public int? risklevelid { get; set; }
        public int? portfolioid { get; set; }
        public int? financialentityid { get; set; }
        public int? currencyid { get; set; }
        public int? displaycurrencyid { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
    }
}
