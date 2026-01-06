using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMidasAPI.Models
{
    public class Projecao
    {
        [Key] // Define a chave primária da tabela
        public int IdProjecao { get; set; }

        [Required, MaxLength(200)] // Campo obrigatório, máximo 200 caracteres
        public string Titulo { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18,2)")] // Define o tipo decimal no banco
        public decimal ValorPrevisto { get; set; }

        public DateTime DataReferencia { get; set; } = DateTime.UtcNow; // Data de referência, campo de busca

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow; // Data/hora de criação, campo de busca e será inserido automaticamente a do sistema
    }
}
