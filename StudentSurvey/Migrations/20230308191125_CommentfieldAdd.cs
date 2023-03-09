using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSurvey.Migrations
{
    /// <inheritdoc />
    public partial class CommentfieldAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "StudentSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "StudentSurveys");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "EmployerSurveys");
        }
    }
}
