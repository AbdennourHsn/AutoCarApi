using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Environments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    dateOfCreation = table.Column<string>(type: "TEXT", nullable: true),
                    NbrOfCars = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarShowroom",
                columns: table => new
                {
                    CarsId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowroomsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarShowroom", x => new { x.CarsId, x.ShowroomsId });
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    RGB = table.Column<int>(type: "INTEGER", nullable: false),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Showrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Descriptiom = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfCreation = table.Column<string>(type: "TEXT", nullable: true),
                    NbrOfCars = table.Column<int>(type: "INTEGER", nullable: false),
                    EnvironmentId = table.Column<int>(type: "INTEGER", nullable: true),
                    OwnerUserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Showrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Showrooms_Environments_EnvironmentId",
                        column: x => x.EnvironmentId,
                        principalTable: "Environments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Textures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    FilePath = table.Column<string>(type: "TEXT", nullable: true),
                    TreeDModelId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreeDModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModelName = table.Column<string>(type: "TEXT", nullable: true),
                    FilePath = table.Column<string>(type: "TEXT", nullable: true),
                    OwnerUserId = table.Column<int>(type: "INTEGER", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Descriptiom = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: true),
                    MaxSpeed = table.Column<int>(type: "INTEGER", nullable: true),
                    Categorie = table.Column<string>(type: "TEXT", nullable: true),
                    Wheel_Descriptiom = table.Column<string>(type: "TEXT", nullable: true),
                    imageId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeDModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreeDModels_Textures_imageId",
                        column: x => x.imageId,
                        principalTable: "Textures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TreeDModels_TreeDModels_CarId",
                        column: x => x.CarId,
                        principalTable: "TreeDModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    admin = table.Column<bool>(type: "INTEGER", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: true),
                    Logo2dId = table.Column<int>(type: "INTEGER", nullable: true),
                    Logo3dId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Textures_Logo2dId",
                        column: x => x.Logo2dId,
                        principalTable: "Textures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_TreeDModels_Logo3dId",
                        column: x => x.Logo3dId,
                        principalTable: "TreeDModels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarShowroom_ShowroomsId",
                table: "CarShowroom",
                column: "ShowroomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_CarId",
                table: "Colors",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CarId",
                table: "Image",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Showrooms_EnvironmentId",
                table: "Showrooms",
                column: "EnvironmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Showrooms_OwnerUserId",
                table: "Showrooms",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Textures_TreeDModelId",
                table: "Textures",
                column: "TreeDModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDModels_CarId",
                table: "TreeDModels",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDModels_imageId",
                table: "TreeDModels",
                column: "imageId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDModels_OwnerUserId",
                table: "TreeDModels",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Logo2dId",
                table: "Users",
                column: "Logo2dId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Logo3dId",
                table: "Users",
                column: "Logo3dId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowroom_Showrooms_ShowroomsId",
                table: "CarShowroom",
                column: "ShowroomsId",
                principalTable: "Showrooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowroom_TreeDModels_CarsId",
                table: "CarShowroom",
                column: "CarsId",
                principalTable: "TreeDModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_TreeDModels_CarId",
                table: "Colors",
                column: "CarId",
                principalTable: "TreeDModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_TreeDModels_CarId",
                table: "Image",
                column: "CarId",
                principalTable: "TreeDModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showrooms_Users_OwnerUserId",
                table: "Showrooms",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Textures_TreeDModels_TreeDModelId",
                table: "Textures",
                column: "TreeDModelId",
                principalTable: "TreeDModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreeDModels_Users_OwnerUserId",
                table: "TreeDModels",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Textures_TreeDModels_TreeDModelId",
                table: "Textures");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_TreeDModels_Logo3dId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CarShowroom");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Showrooms");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.DropTable(
                name: "TreeDModels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Textures");
        }
    }
}
