using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppcoreGit1.Models;

namespace WebAppcoreGit1.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext (DbContextOptions<PlayerDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppcoreGit1.Models.Player> Player { get; set; }
    }
}
