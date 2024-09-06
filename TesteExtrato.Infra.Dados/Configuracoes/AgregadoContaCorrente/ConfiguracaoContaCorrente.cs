using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteExtrato.Dominio.Agregados.AgregadoContaCorrente;
using TesteExtrato.Dominio.Agregados.AgregadoPessoa;

namespace TesteExtrato.Infra.Dados.Configuracoes.AgregadoContaCorrente
{
    public class ConfiguracaoContaCorrente : IEntityTypeConfiguration<ContaCorrente>
    {
        public void Configure(EntityTypeBuilder<ContaCorrente> builder)
        {
            builder.ToTable("ContaCorrente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Agencia).HasMaxLength(8).IsRequired(true);
            builder.Property(x => x.Numero).HasMaxLength(10).IsRequired(true);
            builder.Property(x => x.Saldo).HasColumnType("decimal(18,2)");

            builder.HasOne<Pessoa>()
                .WithMany()
                .HasForeignKey(x => x.ClienteId)
                .IsRequired(true);

            builder.OwnsMany(x => x.Transacoes, tc =>
            {
                tc.ToTable("Transacoes");

                tc.HasKey(x => x.Id);

                tc.Property(x => x.Id)
                    .ValueGeneratedNever()
                    .IsRequired();

                tc.Property(x => x.Tipo)
                    .HasConversion(x => x.Id, x => TipoTransacao.FromId(x))
                    .HasColumnName("TipoTransacaoId")
                    .IsRequired();

                tc.Property(x => x.Valor).HasColumnType("decimal(18,2)");
            });
        }
    }
}
