using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefones_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "Rg" },
                values: new object[] { 2, "503.570.378-98", "29/12/2001", "Thais", "50.661.998-9" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "Rg" },
                values: new object[] { 1, "503.570.378-98", "29/12/2001", "Renan", "50.661.998-9" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "Rg" },
                values: new object[] { 3, "503.570.378-98", "29/12/2001", "Silvao", "50.661.998-9" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cpf", "DataNascimento", "Nome", "Rg" },
                values: new object[] { 4, "503.570.378-98", "29/12/2001", "Victor", "50.661.998-9" });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 1, 2, "Rua Chico Bento", 2 });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 5, 2, "Rua Seila", 1 });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 2, 1, "Rua Maisa", 1 });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 4, 1, "Rua Lindoinha", 2 });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 3, 3, "Rua Luisinho", 0 });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[] { 6, 4, "Rua Chico Bento", 2 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 1, 2, "(11) 1273468", 0 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 2, 2, "(11) 1111111", 2 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 5, 1, "(11) 5555555", 1 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 6, 1, "(11) 9999999", 2 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 3, 3, "(11) 2222222", 1 });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[] { 4, 4, "(11) 4444444", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Enderecos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_ClienteId",
                table: "Telefones",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
