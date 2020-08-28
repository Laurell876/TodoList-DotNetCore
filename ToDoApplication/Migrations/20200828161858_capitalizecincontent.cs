using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoApplication.Migrations
{
    public partial class capitalizecincontent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "content",
                table: "Todos",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Todos",
                newName: "content");
        }
    }
}
