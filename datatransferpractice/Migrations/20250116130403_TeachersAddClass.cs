using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datatransferpractice.Migrations
{
    /// <inheritdoc />
    public partial class TeachersAddClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Standard",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Standard",
                table: "Teachers");
        }
    }
}
