using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp.Migrations
{
    public partial class indiceAtorSegundoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "actor",
                schema: "dbo",
                newName: "actor");

            migrationBuilder.CreateIndex(
                name: "idx_actor_last_name",
                table: "actor",
                column: "last_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "idx_actor_last_name",
                table: "actor");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "actor",
                newName: "actor",
                newSchema: "dbo");
        }
    }
}
