using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Lancamento
{
    [Key]
    public int IdLancamento { get; set; }

    [Required, MaxLength(200)]
    public string Descricao { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Valor { get; set; }

    public DateTime Data { get; set; } = DateTime.UtcNow;
}
