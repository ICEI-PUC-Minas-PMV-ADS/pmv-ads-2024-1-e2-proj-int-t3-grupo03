using System.Data.Entity;

namespace Kippa.Models
{
    public class Contexto : Dbcontext
    {
        public DbSet<lembrete> Lembretes { get; set; }
    }
}