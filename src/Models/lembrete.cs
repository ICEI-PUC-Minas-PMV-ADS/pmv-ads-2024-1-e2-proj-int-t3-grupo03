using System.ComponentModel.DataAnnotations;

namespace Kippa.Models
{
    public class lembrete
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public string Lembrete { get; set; }
        public string Email { get; set;}
    }
}
