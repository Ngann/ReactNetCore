using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactTemplate.Migrations
{
    public partial class RemoveMovieNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Note",
                table: "Movie",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
