using Microsoft.EntityFrameworkCore.Migrations;

namespace undisclosed_back.Migrations
{
    public partial class alter_table_professions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nivel",
                table: "Professions",
                type: "text",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "Professions");
        }
    }
}
