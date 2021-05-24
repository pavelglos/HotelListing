using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "365ea5e6-580a-4833-8484-7ed7465166ab", "6b27c229-a7fd-41d5-be86-09abf9b08970", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94ac3d9c-c299-4aa9-9dc5-ebab3437ea35", "40efc33a-8331-41ff-adff-8eebd3cc8871", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "365ea5e6-580a-4833-8484-7ed7465166ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ac3d9c-c299-4aa9-9dc5-ebab3437ea35");
        }
    }
}
