using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Lancamento
{
    [Key] // Define a chave primária da tabela
    public int IdLancamento { get; set; }

    [Required, MaxLength(200)] // Campo obrigatório, máximo 200 caracteres
    public string Descricao { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")] // Define o tipo decimal no banco
    public decimal Valor { get; set; }

    public DateTime Data { get; set; } = DateTime.UtcNow; // Data do lançamento, campo de busca e será inserido manual

    public DateTime DataCriacao { get; set; } = DateTime.UtcNow; // Data/hora de criação, campo de busca e será inserido automaticamente a do sistema
}
