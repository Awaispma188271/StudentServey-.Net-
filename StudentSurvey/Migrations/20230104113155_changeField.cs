using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSurvey.Migrations
{
    /// <inheritdoc />
    public partial class changeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfGraduate",
                table: "EmployerSurveys");

            migrationBuilder.RenameColumn(
                name: "Bussiness_Type",
                table: "EmployerSurveys",
                newName: "Registration_no");

            migrationBuilder.AddColumn<string>(
                name: "CNIC_no",
                table: "StudentSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Employment_Status",
                table: "StudentSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation_Employer",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation_Evaluator",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployerName",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EvaluatorName",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Job_Level",
                table: "EmployerSurveys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNIC_no",
                table: "StudentSurveys");

            migrationBuilder.DropColumn(
                name: "Employment_Status",
                table: "StudentSurveys");

            migrationBuilder.DropColumn(
                name: "Designation_Employer",
                table: "EmployerSurveys");

            migrationBuilder.DropColumn(
                name: "Designation_Evaluator",
                table: "EmployerSurveys");

            migrationBuilder.DropColumn(
                name: "EmployerName",
                table: "EmployerSurveys");

            migrationBuilder.DropColumn(
                name: "EvaluatorName",
                table: "EmployerSurveys");

            migrationBuilder.DropColumn(
                name: "Job_Level",
                table: "EmployerSurveys");

            migrationBuilder.RenameColumn(
                name: "Registration_no",
                table: "EmployerSurveys",
                newName: "Bussiness_Type");

            migrationBuilder.AddColumn<int>(
                name: "NoOfGraduate",
                table: "EmployerSurveys",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
