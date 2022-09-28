using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{
    public class UsersResponse3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double balance { get; set; }
        public double aportesActuales { get; set; }
    }
}
