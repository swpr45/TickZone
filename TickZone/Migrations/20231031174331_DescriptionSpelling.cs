using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TickZone.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionSpelling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciption",
                table: "Cinema",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinema",
                newName: "Desciption");
        }
    }
}
