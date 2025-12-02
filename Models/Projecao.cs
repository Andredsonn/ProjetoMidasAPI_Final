using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMidasAPI.Models
{
    public class Projecao
    {
        [Key]
        public int IdProjecao { get; set; }

        [Required, MaxLength(200)]
        public string Titulo { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorPrevisto { get; set; }
        public DateTime DataReferencia { get; set; } = DateTime.UtcNow;
    }
}
