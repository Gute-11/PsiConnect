using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiConnect.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoBancodeDadosPsi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CRM",
                table: "Psicologos",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Psicologos",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CRM",
                table: "Psicologos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Psicologos");
        }
    }
}
