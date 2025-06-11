using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CHHA_PlanOfCorrectionAudit.Migrations
{
    /// <inheritdoc />
    public partial class last_modified_by_and_time : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "CHHA_Quality_POC_Responses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "CHHA_Quality_POC_Responses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "CHHA_Quality_POC_Metadata",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "CHHA_Quality_POC_Metadata",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "CHHA_Quality_POC_Metadata");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "CHHA_Quality_POC_Metadata");
        }
    }
}
