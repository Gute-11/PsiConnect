using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiConnect.Migrations
{
    /// <inheritdoc />
    public partial class tabela_Prontuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "psico",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "psico",
                table: "Psicologos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "psico",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "psico",
                table: "Psicologos");
        }
    }
}
