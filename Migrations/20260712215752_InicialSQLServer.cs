using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Conexao_MYSQL.Migrations
{
    /// <inheritdoc />
    public partial class InicialSQLServer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomesProdutos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estoques = table.Column<int>(type: "int", nullable: false),
                    Precos = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
