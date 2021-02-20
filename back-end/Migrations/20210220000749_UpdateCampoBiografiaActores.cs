using Microsoft.EntityFrameworkCore.Migrations;

namespace back_end.Migrations
{
    public partial class UpdateCampoBiografiaActores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Briografia",
                table: "Actores",
                newName: "Biografia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Biografia",
                table: "Actores",
                newName: "Briografia");
        }
    }
}
