using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDWebAPI.Migrations
{
    public partial class seedingRedeSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RedeSocial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoRedeSocial = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    ClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedeSocial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedeSocial_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RedeSocial",
                columns: new[] { "Id", "ClienteId", "Link", "TipoRedeSocial", "Username" },
                values: new object[,]
                {
                    { 1, 1, "www.a.com", 0, "@vitao" },
                    { 2, 2, "www.a.com", 3, "@vitao" },
                    { 3, 3, "www.a.com", 4, "@vitao" },
                    { 4, 4, "www.a.com", 2, "@vitao" },
                    { 5, 5, "www.a.com", 1, "@vitao" },
                    { 6, 6, "www.a.com", 0, "@vitao" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RedeSocial_ClienteId",
                table: "RedeSocial",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RedeSocial");
        }
    }
}
