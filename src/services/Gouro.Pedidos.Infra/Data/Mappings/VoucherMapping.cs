using Gouro.Pedidos.Domain.Vouchers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gouro.Pedidos.Infra.Data.Mappings
{
    public class VoucherMapping : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Codigo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Percentual)
                .HasColumnType("decimal(10,2)");

            builder.Property(c => c.ValorDesconto)
                .HasColumnType("decimal(10,2)");

            builder.ToTable("Vouchers");
        }
    }
}
