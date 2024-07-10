using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartWorkoutDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class trainerid4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role_Id",
                table: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role_Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
