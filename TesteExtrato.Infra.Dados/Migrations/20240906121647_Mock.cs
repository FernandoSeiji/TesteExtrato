using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteExtrato.Infra.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Mock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
             * Essa migration foi criada apenas para gerar uma massa de dados para o exemplo.
             */

            migrationBuilder.Sql(@"
            insert into [teste_extrato].[Pessoa] (Id, Nome) values ('526d3dd5-f90c-4fe2-a410-e03ad18db11c', 'Fernando');

            insert into [teste_extrato].[ContaCorrente] (Id, Agencia, Numero,ClienteId, Saldo) values ('c77c4fed-7ac4-42b6-8e6a-c8919910dedd', '0001', '000001-01', '526d3dd5-f90c-4fe2-a410-e03ad18db11c', 0)

            insert into [teste_extrato].[Transacoes](Id, [Data], TipoTransacaoId, Valor, ContaCorrenteId) values 
            (NEWID(), '2024.08.01', 1, 1000, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.02', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.03', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.04', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.05', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.06', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.07', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.08', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.09', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.10', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.11', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.12', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.13', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.14', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.15', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.16', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.17', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.18', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.19', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.20', 5, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.21', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.22', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.23', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.24', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.25', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.26', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.27', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.28', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.29', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.30', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.08.31', 4, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),

            (NEWID(), '2024.09.01', 1, 1000, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.09.02', 2, -10, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.09.03', 4, -4, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.09.04', 5, -50, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd'),
            (NEWID(), '2024.09.05', 5, -50, 'c77c4fed-7ac4-42b6-8e6a-c8919910dedd')

            update cc set
	            Saldo = (select sum(Valor) from [teste_extrato].[Transacoes] t where t.ContaCorrenteId = cc.Id)
            from [teste_extrato].[ContaCorrente] cc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
