using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartWorkoutDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Roles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role_Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role_Id",
                table: "User");
        }
    }
}
