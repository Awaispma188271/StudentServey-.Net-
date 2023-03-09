using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSurvey.Migrations
{
    /// <inheritdoc />
    public partial class updateEmployerClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question_19",
                table: "EmployerSurveys");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Question_19",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
