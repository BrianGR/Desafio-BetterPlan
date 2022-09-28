using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BrianApis.Models
{
    [Table("goalcategory")]
    public class GoalCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string code { get; set; }
        public string uuid { get; set; }
        public string title { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }



    
    }
}
