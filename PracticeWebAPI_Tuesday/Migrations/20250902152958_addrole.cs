using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PracticeWebAPI_Tuesday.Migrations
{
    /// <inheritdoc />
    public partial class addrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b", null, "Administrator", "ADMINISTRATOR" },
                    { "958e6340-4275-49ed-80ee-2cb5e2fad807", null, "Employee", "EMPLOYEE" },
                    { "f4145e80-361d-4541-b311-9e95b4a95964", null, "Supervisor", "SUPERVISOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "958e6340-4275-49ed-80ee-2cb5e2fad807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4145e80-361d-4541-b311-9e95b4a95964");
        }
    }
}
