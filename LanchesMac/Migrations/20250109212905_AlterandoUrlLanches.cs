using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoUrlLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = 'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg' WHERE LancheId = 1");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = 'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg' WHERE LancheId = 2");
            migrationBuilder.Sql("UPDATE Lanches SET ImagemUrl = 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg' WHERE LancheId = 3");
            migrationBuilder.Sql("UPDATE Lanches SET Nome = 'Cheese Salada' WHERE LancheId = 3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
