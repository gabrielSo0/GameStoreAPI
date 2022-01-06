using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStore.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Plataform = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumberOfPlayers = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOrder = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameOrder",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrdersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameOrder", x => new { x.GamesId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_GameOrder_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamesOrders",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesOrders", x => new { x.GameId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_GamesOrders_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamesOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 1, new DateTime(1998, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel", "123456", "Silva" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 2, new DateTime(1991, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "456789", "Wick" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 3, new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darth", "789456", "Vader" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Surname" },
                values: new object[] { 4, new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", "515846", "Laura" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Brand", "Description", "Genre", "Name", "NumberOfPlayers", "Plataform", "Price", "ReleaseDate" },
                values: new object[] { 1, null, null, "Action", "Ghost Of Tsushima", null, null, 64.109999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Brand", "Description", "Genre", "Name", "NumberOfPlayers", "Plataform", "Price", "ReleaseDate" },
                values: new object[] { 2, null, null, "Action", "Marvels Guardians of the Galaxy", null, null, 29.989999999999998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Brand", "Description", "Genre", "Name", "NumberOfPlayers", "Plataform", "Price", "ReleaseDate" },
                values: new object[] { 3, null, null, "RPG", "The Witcher 3", null, null, 33.990000000000002, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Brand", "Description", "Genre", "Name", "NumberOfPlayers", "Plataform", "Price", "ReleaseDate" },
                values: new object[] { 4, null, null, "Action", "God of War", null, null, 19.989999999999998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DateOrder" },
                values: new object[] { 1, 1, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DateOrder" },
                values: new object[] { 2, 2, new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DateOrder" },
                values: new object[] { 3, 3, new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DateOrder" },
                values: new object[] { 4, 4, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "GamesOrders",
                columns: new[] { "GameId", "OrderId" },
                values: new object[] { 4, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_GameOrder_OrdersId",
                table: "GameOrder",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesOrders_OrderId",
                table: "GamesOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameOrder");

            migrationBuilder.DropTable(
                name: "GamesOrders");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
