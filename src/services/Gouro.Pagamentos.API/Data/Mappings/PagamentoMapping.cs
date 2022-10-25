using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Gouro.Pagamentos.API.Models;

namespace Gouro.Pagamentos.API.Data.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Ignore(c => c.CartaoCredito);

            builder.Property(c => c.Valor)
                .HasColumnType("decimal(10,2)");

            // 1 : N => Pagamento : Transacao
            builder.HasMany(c => c.Transacoes)
                   .WithOne(c => c.Pagamento)
                   .HasForeignKey(c => c.PagamentoId);

            builder.ToTable("Pagamentos");
        }
    }
}