using Microsoft.EntityFrameworkCore.Migrations;

namespace FUP_Projeto.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Cargo = table.Column<string>(maxLength: 60, nullable: false),
                    Chefe = table.Column<string>(maxLength: 60, nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    Salario = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
