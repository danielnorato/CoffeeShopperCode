using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddCoffeeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO CoffeeShops(Name,OpeningHours,Address) VALUES('Starbuck paranagua','8-5 Segunda-sabado','Rua Alvorada 3923')");

            migrationBuilder.Sql($"INSERT INTO CoffeeShops(Name,OpeningHours,Address) VALUES('Starbuck Curitiba','10-11 Segunda-sabado','Rua Ibipora 25')");

            migrationBuilder.Sql($"INSERT INTO CoffeeShops(Name,OpeningHours,Address) VALUES('Starbuck Pato Branco','7-8 Segunda-sabado','Rua Matriz 800')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
