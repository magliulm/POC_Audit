using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CHHA_PlanOfCorrectionAudit.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHHA_Quality_POC_Metadata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_MRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patient_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Borough_of_Care = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_of_Care_Date = table.Column<DateOnly>(type: "date", nullable: true),
                    Financial_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assigned_Reviewer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Assigned = table.Column<DateOnly>(type: "date", nullable: true),
                    Form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHHA_Quality_POC_Metadata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHHA_Quality_POC_Responses",
                columns: table => new
                {
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_MRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Assigned = table.Column<DateOnly>(type: "date", nullable: true),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetadataId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHHA_Quality_POC_Responses", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_CHHA_Quality_POC_Responses_CHHA_Quality_POC_Metadata_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "CHHA_Quality_POC_Metadata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CHHA_Quality_POC_Responses_MetadataId",
                table: "CHHA_Quality_POC_Responses",
                column: "MetadataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropTable(
                name: "CHHA_Quality_POC_Metadata");
        }
    }
}
