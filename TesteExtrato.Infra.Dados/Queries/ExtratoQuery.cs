using Dapper;
using Microsoft.EntityFrameworkCore;
using TesteExtrato.Abstracoes.Queries;
using TesteExtrato.Abstracoes.ViewModels;

namespace TesteExtrato.Infra.Dados.Queries
{
    public class ExtratoQuery : IExtratoQuery
    {
        private LocalContext ctx;

        public ExtratoQuery(LocalContext ctx)
        {
            this.ctx = ctx;
        }

        public Task<IEnumerable<TransacaoDto>> Get(string agencia, string numeroConta, DateTime dataInicio)
        {
            var sql = @"
            select 
	            t.[Data],
	            tp.Nome as TipoTransacao,
	            t.Valor
            from 
	            [teste_extrato].[ContaCorrente] cc
	            inner join [teste_extrato].[Transacoes] t on cc.Id = t.ContaCorrenteId
	            inner join [teste_extrato].TipoTransacao tp on t.TipoTransacaoId = tp.Id
            where
	            cc.Agencia = @agencia
	            and cc.Numero = @numeroConta
	            and t.[Data] >= @dataInicio
            order by [Data] desc";

            var conexao = ctx.Database.GetDbConnection();

            return conexao.QueryAsync<TransacaoDto>(sql, new { agencia, numeroConta, dataInicio });
        }
    }
}
