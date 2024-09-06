using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteExtrato.Dominio.Agregados.AgregadoContaCorrente;

namespace TesteExtrato.Infra.Dados.Configuracoes.AgregadoContaCorrente
{
    public class ConfiguracaoTipoTransacao : IEntityTypeConfiguration<TipoTransacao>
    {
        public void Configure(EntityTypeBuilder<TipoTransacao> builder)
        {
            builder.ToTable("TipoTransacao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired(true);

            builder.HasData(TipoTransacao.List());
        }
    }
}
