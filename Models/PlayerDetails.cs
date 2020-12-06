using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETD3202_Lab5_RyanClayson.Models
{
    public class PlayerDetails
    {
        [Key]
        public int pID { get; set; }
        public int playerAge { get; set; }
        public string playerHeight { get; set; }
        public int playerWeight { get; set; }
        
        [ForeignKey("pID")]
        public virtual Player playerID { get; set; }

    }
}
