using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kippa.Models;

namespace Kippa.Data
{
    public class KippaContext : DbContext
    {
        public KippaContext (DbContextOptions<KippaContext> options)
            : base(options)
        {
        }

        public DbSet<Kippa.Models.lembrete> lembrete { get; set; } = default!;
    }
}
