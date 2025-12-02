using Microsoft.EntityFrameworkCore;
using ProjetoMidasAPI.Models;

namespace ProjetoMidasAPI.Data
{
    // Essa classe é o "coração" do EF Core: conecta os Models ao banco
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Cada DbSet vira uma tabela no banco
        public DbSet<Projecao> Projecoes { get; set; } = null!;
        public DbSet<Lancamento> Lancamentos { get; set; } = null!;

        // É aqui que você coloca o OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define nomes de tabelas e chaves primárias
            modelBuilder.Entity<Projecao>().ToTable("Projecoes");
            modelBuilder.Entity<Projecao>().HasKey(p => p.IdProjecao);

            modelBuilder.Entity<Lancamento>().ToTable("Lancamentos");
            modelBuilder.Entity<Lancamento>().HasKey(l => l.IdLancamento);

            // Corrige os avisos de decimal
            modelBuilder.Entity<Projecao>()
                .Property(p => p.ValorPrevisto)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Lancamento>()
                .Property(l => l.Valor)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
