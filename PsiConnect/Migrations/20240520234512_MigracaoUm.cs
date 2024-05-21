using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiConnect.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Psicologos",
                columns: table => new
                {
                    PsicologosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Primeiro_nome_p = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Sobrenome_p = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email_p = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Cpf_p = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Celular_p = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Area_atuacao_p = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Senha_p = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Genero_p = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psicologos", x => x.PsicologosId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Primeiro_nome_u = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Sobrenome_u = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email_u = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Cpf_u = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Celular_u = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Ctt_emer_u = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Senha_u = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Genero_u = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Psicologos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
