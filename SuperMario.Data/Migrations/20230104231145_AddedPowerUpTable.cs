using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMario.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPowerUpTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PowerUps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    MarioId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerUps_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PowerUps_Marios_MarioId",
                        column: x => x.MarioId,
                        principalTable: "Marios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PowerUps_LevelId",
                table: "PowerUps",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerUps_MarioId",
                table: "PowerUps",
                column: "MarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerUps");
        }
    }
}
