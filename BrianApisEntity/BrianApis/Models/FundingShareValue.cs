﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    [Table("fundingsharevalue")]

    public class FundingShareValue
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public double value { get; set; }

        public DateTime date { get; set; }

        public int? fundingid { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }
    }
}
