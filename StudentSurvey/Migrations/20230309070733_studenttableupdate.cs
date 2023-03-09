using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSurvey.Migrations
{
    /// <inheritdoc />
    public partial class studenttableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Question_21",
                table: "StudentSurveys");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Question_21",
                table: "StudentSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
