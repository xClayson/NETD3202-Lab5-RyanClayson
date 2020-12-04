using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NETD3202_Lab5_RyanClayson.Models;

namespace NETD3202_Lab5_RyanClayson.Models
{
    public class PlayerContext : DbContext
    {

        //Constructor for PlayerContext
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {



        }

        public DbSet<Player> Players { get; set; }

        public DbSet<NETD3202_Lab5_RyanClayson.Models.PlayerDetails> PlayerDetails { get; set; }
    }
}
