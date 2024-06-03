using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppToDo.Migrations
{
    /// <inheritdoc />
    public partial class Showdatalast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowData",
                table: "Todos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowData",
                table: "Todos");
        }
    }
}
