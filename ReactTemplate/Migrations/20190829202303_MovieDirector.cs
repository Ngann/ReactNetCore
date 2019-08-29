using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactTemplate.Migrations
{
    public partial class MovieDirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");
        }
    }
}
