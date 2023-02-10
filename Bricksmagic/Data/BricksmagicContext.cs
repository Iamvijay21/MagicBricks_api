using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bricksmagic.Models;

namespace Bricksmagic.Data
{
    public class BricksmagicContext : DbContext
    {
        public BricksmagicContext (DbContextOptions<BricksmagicContext> options)
            : base(options)
        {
        }

        public DbSet<Bricksmagic.Models.Users> Users { get; set; } = default!;

        public DbSet<Bricksmagic.Models.Properties> Properties { get; set; }

        public DbSet<Bricksmagic.Models.Transaction> Transaction { get; set; }
    }
}
