using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentSurvey.Migrations
{
    /// <inheritdoc />
    public partial class employeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question1 = table.Column<string>(name: "Question_1", type: "nvarchar(max)", nullable: false),
                    Question2 = table.Column<string>(name: "Question_2", type: "nvarchar(max)", nullable: false),
                    Question3 = table.Column<string>(name: "Question_3", type: "nvarchar(max)", nullable: false),
                    Question4 = table.Column<string>(name: "Question_4", type: "nvarchar(max)", nullable: false),
                    Question5 = table.Column<string>(name: "Question_5", type: "nvarchar(max)", nullable: false),
                    Question6 = table.Column<string>(name: "Question_6", type: "nvarchar(max)", nullable: false),
                    Question7 = table.Column<string>(name: "Question_7", type: "nvarchar(max)", nullable: false),
                    Question8 = table.Column<string>(name: "Question_8", type: "nvarchar(max)", nullable: false),
                    Question9 = table.Column<string>(name: "Question_9", type: "nvarchar(max)", nullable: false),
                    Question10 = table.Column<string>(name: "Question_10", type: "nvarchar(max)", nullable: false),
                    Question11 = table.Column<string>(name: "Question_11", type: "nvarchar(max)", nullable: false),
                    Question12 = table.Column<string>(name: "Question_12", type: "nvarchar(max)", nullable: false),
                    Question13 = table.Column<string>(name: "Question_13", type: "nvarchar(max)", nullable: false),
                    Question14 = table.Column<string>(name: "Question_14", type: "nvarchar(max)", nullable: false),
                    Question15 = table.Column<string>(name: "Question_15", type: "nvarchar(max)", nullable: false),
                    Question16 = table.Column<string>(name: "Question_16", type: "nvarchar(max)", nullable: false),
                    Question17 = table.Column<string>(name: "Question_17", type: "nvarchar(max)", nullable: false),
                    Question18 = table.Column<string>(name: "Question_18", type: "nvarchar(max)", nullable: false),
                    Question19 = table.Column<string>(name: "Question_19", type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationName = table.Column<string>(name: "Organization_Name", type: "nvarchar(max)", nullable: false),
                    BussinessType = table.Column<string>(name: "Bussiness_Type", type: "nvarchar(max)", nullable: false),
                    NoOfGraduate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSurveys", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeSurveys");
        }
    }
}
