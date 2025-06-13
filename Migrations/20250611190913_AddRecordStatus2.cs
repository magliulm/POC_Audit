using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CHHA_PlanOfCorrectionAudit.Migrations
{
    /// <inheritdoc />
    public partial class AddRecordStatus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecordStatus",
                table: "CHHA_Quality_POC_Responses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecordStatus",
                table: "CHHA_Quality_POC_Metadata",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordStatus",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "RecordStatus",
                table: "CHHA_Quality_POC_Metadata");
        }
    }
}
