using TesteExtrato.Dominio.Agregados.AgregadoContaCorrente;

namespace TesteExtrato.Abstracoes.Repositorios
{
    public interface IContaCorrenteRepositorio
    {
        Task<ContaCorrente?> GetByIdAsync(string id);
        Task AddAsync(ContaCorrente entity);
        void Update(ContaCorrente entity);
        void Delete(ContaCorrente entity);
        void SaveChange();
    }
}
