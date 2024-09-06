using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TesteExtrato.Infra.Dados.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "teste_extrato");

            migrationBuilder.CreateTable(
                name: "Pessoa",
                schema: "teste_extrato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTransacao",
                schema: "teste_extrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContaCorrente",
                schema: "teste_extrato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Agencia = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCorrente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContaCorrente_Pessoa_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "teste_extrato",
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                schema: "teste_extrato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoTransacaoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContaCorrenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transacoes_ContaCorrente_ContaCorrenteId",
                        column: x => x.ContaCorrenteId,
                        principalSchema: "teste_extrato",
                        principalTable: "ContaCorrente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "teste_extrato",
                table: "TipoTransacao",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Valor depositado" },
                    { 2, "Valor sacado" },
                    { 3, "Transferência recebida" },
                    { 4, "Transferência enviada" },
                    { 5, "Pagamento realizado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaCorrente_ClienteId",
                schema: "teste_extrato",
                table: "ContaCorrente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_ContaCorrenteId",
                schema: "teste_extrato",
                table: "Transacoes",
                column: "ContaCorrenteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoTransacao",
                schema: "teste_extrato");

            migrationBuilder.DropTable(
                name: "Transacoes",
                schema: "teste_extrato");

            migrationBuilder.DropTable(
                name: "ContaCorrente",
                schema: "teste_extrato");

            migrationBuilder.DropTable(
                name: "Pessoa",
                schema: "teste_extrato");
        }
    }
}
