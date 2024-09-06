using Microsoft.EntityFrameworkCore;
using TesteExtrato.Abstracoes.Repositorios;
using TesteExtrato.Dominio.Agregados.AgregadoContaCorrente;

namespace TesteExtrato.Infra.Dados.Repositorios
{
    public class ContaCorrenteRepositorio : IContaCorrenteRepositorio
    {
        private LocalContext ctx;
        private DbSet<ContaCorrente> dbset;

        public ContaCorrenteRepositorio(LocalContext ctx)
        {
            this.ctx = ctx;
            dbset = ctx.Set<ContaCorrente>();
        }

        public async Task<ContaCorrente?> GetByIdAsync(string id)
        {
            return await dbset.FindAsync(id);
        }

        public async Task AddAsync(ContaCorrente entity)
        {
            await dbset.AddAsync(entity);
        }

        public void Update(ContaCorrente entity)
        {
            dbset.Update(entity);
        }

        public void Delete(ContaCorrente entity)
        {
            dbset.Remove(entity);
        }

        public void SaveChange()
        {
            ctx.SaveChanges();
        }
    }
}
