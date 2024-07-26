using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace userManagement.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28c89693-0293-4090-ad71-4bc0dc146f24", "e68471a4-9adf-4afb-b4d9-e4b171560f1d", "client", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d18ee7db-f5c6-4fbf-8f99-cf7c4028f27c", "c991fa04-09c3-46c7-9bf4-9a75c943fce9", "seller", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4cd467a-33fb-4bab-bd63-6e32bc9a686e", "665f9baf-46ee-413a-b1c3-d957b2fca689", "admin", "seller" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28c89693-0293-4090-ad71-4bc0dc146f24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d18ee7db-f5c6-4fbf-8f99-cf7c4028f27c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4cd467a-33fb-4bab-bd63-6e32bc9a686e");
        }
    }
}
