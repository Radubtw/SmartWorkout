using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartWorkoutDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class trainer_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Trainer_Id",
                table: "User",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trainer_Id",
                table: "User");
        }
    }
}
