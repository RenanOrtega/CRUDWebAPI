using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDWebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                values: new object[,]
                {
                    { 1, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thais", "50.661.998-9" },
                    { 2, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renan", "50.661.998-9" },
                    { 3, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silvao", "50.661.998-9" },
                    { 4, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor", "50.661.998-9" },
                    { 5, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thais", "50.661.998-9" },
                    { 6, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renan", "50.661.998-9" },
                    { 7, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silvao", "50.661.998-9" },
                    { 8, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor", "50.661.998-9" },
                    { 9, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silvao", "50.661.998-9" },
                    { 10, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor", "50.661.998-9" },
                    { 11, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thais", "50.661.998-9" },
                    { 12, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renan", "50.661.998-9" },
                    { 13, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silvao", "50.661.998-9" },
                    { 14, "503.570.378-98", new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor", "50.661.998-9" }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "ClienteId", "Nome", "Tipo" },
                values: new object[,]
                {
                    { 2, 1, "Rua HH", 1 },
                    { 1, 2, "Rua II", 2 },
                    { 11, 13, "Rua YY", 1 },
                    { 3, 3, "Rua GG", 0 },
                    { 10, 12, "Rua ZZ", 2 },
                    { 4, 4, "Rua FF", 2 },
                    { 5, 5, "Rua EE", 1 },
                    { 9, 11, "Rua LAA", 0 },
                    { 8, 10, "Rua BB", 1 },
                    { 6, 7, "Rua DD", 2 },
                    { 12, 14, "Rua XX", 2 },
                    { 7, 8, "Rua CC", 2 }
                });

            migrationBuilder.InsertData(
                table: "Telefones",
                columns: new[] { "Id", "ClienteId", "Numero", "Tipo" },
                values: new object[,]
                {
                    { 12, 13, "(11) 121212121", 2 },
                    { 14, 12, "(11) 14141414", 1 },
                    { 15, 11, "(11) 15151515", 2 },
                    { 9, 9, "(11) 2222222", 1 },
                    { 6, 7, "(11) 9999999", 2 },
                    { 11, 7, "(11) 111111111", 1 },
                    { 5, 6, "(11) 5555555", 1 },
                    { 7, 5, "(11) 1273468", 0 },
                    { 4, 4, "(11) 4444444", 0 },
                    { 3, 3, "(11) 2222222", 1 },
                    { 8, 2, "(11) 1111111", 2 },
                    { 2, 2, "(11) 1111111", 2 },
                    { 1, 2, "(11) 1273468", 0 },
                    { 10, 8, "(11) 100001010", 0 },
                    { 13, 14, "(11) 133131313", 0 }
                });

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
