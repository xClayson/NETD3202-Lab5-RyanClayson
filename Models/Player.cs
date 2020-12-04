using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202_Lab5_RyanClayson.Models
{
    public class Player
    {
        [Key]
        public int playerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearDrafted { get; set; }
        public string teamName { get; set; }

    }
}
