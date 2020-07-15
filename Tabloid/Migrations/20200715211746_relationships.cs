using Microsoft.EntityFrameworkCore.Migrations;

namespace Tabloid.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                column: "FirebaseUserId",
                value: "AM2N3SOStGX2rheUhxk6eEWvmsi2");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                column: "FirebaseUserId",
                value: "RdrLC9WsHrWtSkK5F1uDKmgdSAz1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 1,
                column: "FirebaseUserId",
                value: "TBD");

            migrationBuilder.UpdateData(
                table: "UserProfile",
                keyColumn: "Id",
                keyValue: 2,
                column: "FirebaseUserId",
                value: "TBD");
        }
    }
}
