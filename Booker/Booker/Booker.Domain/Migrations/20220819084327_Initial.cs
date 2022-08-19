using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booker.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isRented = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movies_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Contact", "Name" },
                values: new object[,]
                {
                    { new Guid("2c18c39b-3bc1-4bd4-ab93-937d41b210c3"), 362035652L, "Nino" },
                    { new Guid("2ceb1f4b-fa4d-4375-abe6-a3bec97539df"), 125874256L, "Gytis" },
                    { new Guid("37aebf67-bca4-4bea-a48f-fb7e960637a0"), 4269875136L, "Yan" },
                    { new Guid("3a92ad5c-4b0f-479d-8ae5-3f69fe6b5479"), 1234852121L, "Carson" },
                    { new Guid("5ccf1cc9-81b2-4819-a7b7-8debcab9a079"), 4852618224L, "Meredith" },
                    { new Guid("66d0d543-45ad-48df-b3c5-20fa37fe0b24"), 5842016982L, "Arturo" },
                    { new Guid("c2902351-2ac8-4cd2-858b-9c25b7af59f8"), 785129634L, "Peggy" },
                    { new Guid("e14c7382-2e4e-41fc-9b94-3a4ac7b4579e"), 78129647L, "Laura" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "CustomerID", "Description", "Title", "isRented" },
                values: new object[,]
                {
                    { new Guid("370c2e80-5967-44b1-86ae-b213a2a919cd"), null, "When Peter Venkman, Raymond Stantz and Egon Spengler lose their jobs as scientists, they start an establishment called Ghostbusters to fight the evil ghosts lurking in New York City.", "Ghostbusters", false },
                    { new Guid("c546e6ef-3eb1-43fe-b34f-89987b517152"), null, "Four years after the destruction of Isla Nublar, dinosaurs now live and hunt alongside humans all over the world. This fragile balance will reshape the future and determine, once and for all, whether human beings are to remain the apex predators on a planet they now share with history's most fearsome creatures.", "Jurassic World", false },
                    { new Guid("d4ed3892-008e-4972-9242-48ec14930065"), null, "James Halliday designs a virtual reality and hides the keys to his fortune in it for a worthy player to find after his death. Wade, a teenager, sets out on a quest to find the keys and the fortune.", "Ready Player One", false },
                    { new Guid("ed95b142-1f1f-460e-8445-279f7aff682d"), null, "Ant-Man is a 2015 American superhero film based on the Marvel Comics characters of the same name: Scott Lang and Hank Pym. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 12th film in the Marvel Cinematic Universe (MCU).", "Antman", false }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "CustomerID", "Description", "Title", "isRented" },
                values: new object[] { new Guid("c2fad76f-cb31-4141-aaa5-354c66d85546"), new Guid("66d0d543-45ad-48df-b3c5-20fa37fe0b24"), "Moana, daughter of chief Tui, embarks on a journey to return the heart of goddess Te Fitti from Maui, a demigod, after the plants and the fish on her island start dying due to a blight.", "Moana", true });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CustomerID",
                table: "Movies",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
