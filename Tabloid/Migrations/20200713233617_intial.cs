using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tabloid.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirebaseUserId = table.Column<string>(maxLength: 28, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    ImageLocation = table.Column<string>(maxLength: 255, nullable: true),
                    UserTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_UserType_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Author" });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "CreateDateTime", "DisplayName", "Email", "FirebaseUserId", "FirstName", "ImageLocation", "LastName", "UserTypeId" },
                values: new object[] { 1, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "gteanby6", "gteanby6@craigslist.orgx", "TBD", "Giuseppe", "placeholder1.jpeg", "Teanby", 1 });

            migrationBuilder.InsertData(
                table: "UserProfile",
                columns: new[] { "Id", "CreateDateTime", "DisplayName", "Email", "FirebaseUserId", "FirstName", "ImageLocation", "LastName", "UserTypeId" },
                values: new object[] { 2, new DateTime(2020, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ecornfoot8", "ecornfoot8@cargocollective.comx", "TBD", "Emmaline", "placeholder2.jpeg", "Cornfoot", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_UserTypeId",
                table: "UserProfile",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
