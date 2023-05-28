using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForElcom.Migrations
{
    /// <inheritdoc />
    public partial class Logins2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Login");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Login",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
