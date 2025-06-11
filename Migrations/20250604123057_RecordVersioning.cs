using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CHHA_PlanOfCorrectionAudit.Migrations
{
    /// <inheritdoc />
    public partial class RecordVersioning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CHHA_Quality_POC_Responses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CHHA_Quality_POC_Responses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentVersion",
                table: "CHHA_Quality_POC_Responses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "OriginalRecordId",
                table: "CHHA_Quality_POC_Responses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RecordId",
                table: "CHHA_Quality_POC_Responses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CHHA_Quality_POC_Metadata",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CHHA_Quality_POC_Metadata",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentVersion",
                table: "CHHA_Quality_POC_Metadata",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "OriginalRecordId",
                table: "CHHA_Quality_POC_Metadata",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RecordId",
                table: "CHHA_Quality_POC_Metadata",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "IsCurrentVersion",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "OriginalRecordId",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "CHHA_Quality_POC_Responses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CHHA_Quality_POC_Metadata");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CHHA_Quality_POC_Metadata");

            migrationBuilder.DropColumn(
                name: "IsCurrentVersion",
                table: "CHHA_Quality_POC_Metadata");

            migrationBuilder.DropColumn(
                name: "OriginalRecordId",
                table: "CHHA_Quality_POC_Metadata");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "CHHA_Quality_POC_Metadata");
        }
    }
}
