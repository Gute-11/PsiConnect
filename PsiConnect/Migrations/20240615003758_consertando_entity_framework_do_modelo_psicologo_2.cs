using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiConnect.Migrations
{
    /// <inheritdoc />
    public partial class consertando_entity_framework_do_modelo_psicologo_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area_atuacao_p",
                table: "Psicologos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Area_atuacao_p",
                table: "Psicologos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
