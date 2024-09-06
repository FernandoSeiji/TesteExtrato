using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteExtrato.Dominio.Agregados.AgregadoPessoa;
using TesteExtrato.Infra.Dados.Mock;

namespace TesteExtrato.Infra.Dados.Configuracoes.AgregadoCliente
{
    public class ConfiguracaoPessoa : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Nome).HasMaxLength(200);
        }
    }
}
