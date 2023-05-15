using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure_.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertyAirline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassengerId",
                table: "FlightPassenger");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "Passengers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PassengersPassengerId",
                table: "FlightPassenger",
                newName: "PassengersId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPassengerId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersId");

            migrationBuilder.AddColumn<string>(
                name: "Airline",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "Airline",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Passengers",
                newName: "PassengerId");

            migrationBuilder.RenameColumn(
                name: "PassengersId",
                table: "FlightPassenger",
                newName: "PassengersPassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassengerId",
                table: "FlightPassenger",
                column: "PassengersPassengerId",
                principalTable: "Passengers",
                principalColumn: "PassengerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
