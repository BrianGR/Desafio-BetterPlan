using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrianApis.Models
{

    public class UserResponse1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombreCompleto { get; set; }
        public string nombreCompletoAdvisor { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}

