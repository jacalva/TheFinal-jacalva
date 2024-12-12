using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheFinal_jacalva.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GameTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CopiesSold = table.Column<double>(type: "REAL", nullable: false),
                    YearReleased = table.Column<double>(type: "REAL", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    StudioID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudioName = table.Column<string>(type: "TEXT", nullable: false),
                    acquisitionyear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.StudioID);
                });

            migrationBuilder.CreateTable(
                name: "StudioGames",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "INTEGER", nullable: false),
                    StudioID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudioGames", x => new { x.GameID, x.StudioID });
                    table.ForeignKey(
                        name: "FK_StudioGames_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudioGames_Studios_StudioID",
                        column: x => x.StudioID,
                        principalTable: "Studios",
                        principalColumn: "StudioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudioGames_StudioID",
                table: "StudioGames",
                column: "StudioID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudioGames");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Studios");
        }
    }
}
