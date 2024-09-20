using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RiskOfRainTracker.Migrations
{
    /// <inheritdoc />
    public partial class initRunAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RunAttributes",
                columns: table => new
                {
                    RunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RunParticipantIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunUDifficultyId = table.Column<int>(type: "int", nullable: false),
                    ModdedRun = table.Column<bool>(type: "bit", nullable: false),
                    ModProfileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DLCRun = table.Column<bool>(type: "bit", nullable: false),
                    DLCIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UArtifactIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunLevelEnd = table.Column<int>(type: "int", nullable: false),
                    RunDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RunLengthHours = table.Column<int>(type: "int", nullable: false),
                    RunLengthMinutes = table.Column<int>(type: "int", nullable: false),
                    FoughtMithrix = table.Column<bool>(type: "bit", nullable: false),
                    BeatMitrhrix = table.Column<bool>(type: "bit", nullable: true),
                    AlternateEnding = table.Column<bool>(type: "bit", nullable: true),
                    AlternateEndingId = table.Column<int>(type: "int", nullable: false),
                    BeatAlternateEnding = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunAttributes", x => x.RunId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RunAttributes");
        }
    }
}
