using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPubl.Migrations
{
    public partial class addPermalink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permalink",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permalink",
                table: "Posts");
        }
    }
}
