using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstExample.Migrations
{
    /// <inheritdoc />
    public partial class v08052024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
