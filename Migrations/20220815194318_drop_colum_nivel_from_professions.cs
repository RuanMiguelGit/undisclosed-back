using Microsoft.EntityFrameworkCore.Migrations;

namespace undisclosed_back.Migrations
{
    public partial class drop_colum_nivel_from_professions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Professions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nivel",
                table: "Professions",
                type: "text",
                nullable: false);
        }
    }
}
