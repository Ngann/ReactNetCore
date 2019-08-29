using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactTemplate.Migrations
{
    public partial class MovieReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Review",
                table: "Movie",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Review",
                table: "Movie");
        }
    }
}
