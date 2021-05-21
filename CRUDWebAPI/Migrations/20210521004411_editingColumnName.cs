using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDWebAPI.Migrations
{
    public partial class editingColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoRedeSocial",
                table: "RedeSocial");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "RedeSocial",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tipo",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tipo",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tipo",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tipo",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "RedeSocial");

            migrationBuilder.AddColumn<int>(
                name: "TipoRedeSocial",
                table: "RedeSocial",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoRedeSocial",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 3,
                column: "TipoRedeSocial",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 4,
                column: "TipoRedeSocial",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RedeSocial",
                keyColumn: "Id",
                keyValue: 5,
                column: "TipoRedeSocial",
                value: 1);
        }
    }
}
