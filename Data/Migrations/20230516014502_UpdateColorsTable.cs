using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId1",
                table: "Colors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colors_CarId1",
                table: "Colors",
                column: "CarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_TreeDModels_CarId1",
                table: "Colors",
                column: "CarId1",
                principalTable: "TreeDModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_TreeDModels_CarId1",
                table: "Colors");

            migrationBuilder.DropIndex(
                name: "IX_Colors_CarId1",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "Colors");
        }
    }
}
