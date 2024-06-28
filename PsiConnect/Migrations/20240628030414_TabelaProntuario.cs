using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiConnect.Migrations
{
    /// <inheritdoc />
    public partial class TabelaProntuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    ProntuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Paciente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Idade_Paciente = table.Column<int>(type: "int", nullable: true),
                    Data_Consulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tratamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.ProntuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prontuario");
        }
    }
}
