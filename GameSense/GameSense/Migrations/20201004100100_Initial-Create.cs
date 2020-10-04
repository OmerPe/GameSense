using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameSense.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gamedb",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    ageRestriction = table.Column<int>(nullable: false),
                    Developer = table.Column<string>(nullable: false),
                    DeveloperLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Views = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamedb", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usrdb",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usrdb", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GameList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(nullable: false),
                    gameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GameList_Gamedb_gameId",
                        column: x => x.gameId,
                        principalTable: "Gamedb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameList_Usrdb_userId",
                        column: x => x.userId,
                        principalTable: "Usrdb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameList_gameId",
                table: "GameList",
                column: "gameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameList_userId",
                table: "GameList",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameList");

            migrationBuilder.DropTable(
                name: "Gamedb");

            migrationBuilder.DropTable(
                name: "Usrdb");
        }
    }
}
