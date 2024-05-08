using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstExample.Migrations
{
    /// <inheritdoc />
    public partial class V2_080520242240 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Vessels_VesselId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_VesselId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "VesselId",
                table: "Owners");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Vessels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vessels_OwnerId",
                table: "Vessels",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vessels_Owners_OwnerId",
                table: "Vessels",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vessels_Owners_OwnerId",
                table: "Vessels");

            migrationBuilder.DropIndex(
                name: "IX_Vessels_OwnerId",
                table: "Vessels");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Vessels");

            migrationBuilder.AddColumn<int>(
                name: "VesselId",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_VesselId",
                table: "Owners",
                column: "VesselId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Vessels_VesselId",
                table: "Owners",
                column: "VesselId",
                principalTable: "Vessels",
                principalColumn: "VesselId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
