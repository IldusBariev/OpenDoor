using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenDoorApi.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicantEntity",
                table: "ApplicantEntity");

            migrationBuilder.RenameTable(
                name: "ApplicantEntity",
                newName: "Applicants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applicants",
                table: "Applicants",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Applicants",
                table: "Applicants");

            migrationBuilder.RenameTable(
                name: "Applicants",
                newName: "ApplicantEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicantEntity",
                table: "ApplicantEntity",
                column: "Id");
        }
    }
}
