using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    public class UsersResponse2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double balance { get; set; }
        public double aportesActuales { get; set; }
    }
}
