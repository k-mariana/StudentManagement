using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "StudentFirstName", "StudentLastName" },
                values: new object[,]
                {
                    { 1, "John", "Smith" },
                    { 2, "Anna", "Brown" },
                    { 3, "Michael", "Johnson" },
                    { 4, "Emily", "Davis" },
                    { 5, "David", "Wilson" },
                    { 6, "Sophia", "Miller" },
                    { 7, "Daniel", "Moore" },
                    { 8, "Olivia", "Taylor" },
                    { 9, "James", "Anderson" },
                    { 10, "Emma", "Thomas" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserLogin", "UserPassword" },
                values: new object[] { 1, "admin", "AQAAAAIAAYagAAAAEJy80kguewONZOfDnVVVRH3r9bk9t9WXeuRMNVndPcd1gMrtdlcpMtvK+C7KRlas5w==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
