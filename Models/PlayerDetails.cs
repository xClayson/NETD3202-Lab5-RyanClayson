/* Ryan Clayson
 * NETD 3202 - Lab 5
 * December 6, 2020
 * This ASP.NET Core application is designed to allow the user to enter an NBA Player and add it to a database
 */
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
        public int playerID { get; set; } //priamry key of table
        public int playerAge { get; set; } // Age of Player
        public string playerHeight { get; set; }// Height of Player
        public int playerWeight { get; set; } // Weight of Player     

    }
}
