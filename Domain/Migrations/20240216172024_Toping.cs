using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class Toping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeDTOTopingDTO");

            migrationBuilder.DropTable(
                name: "Topings");

            migrationBuilder.AddColumn<bool>(
                name: "IsToping",
                table: "ingredients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsToping",
                table: "ingredients");

            migrationBuilder.CreateTable(
                name: "Topings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Qty = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeDTOTopingDTO",
                columns: table => new
                {
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: false),
                    TopingsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDTOTopingDTO", x => new { x.RecipesId, x.TopingsId });
                    table.ForeignKey(
                        name: "FK_RecipeDTOTopingDTO_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeDTOTopingDTO_Topings_TopingsId",
                        column: x => x.TopingsId,
                        principalTable: "Topings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDTOTopingDTO_TopingsId",
                table: "RecipeDTOTopingDTO",
                column: "TopingsId");
        }
    }
}
