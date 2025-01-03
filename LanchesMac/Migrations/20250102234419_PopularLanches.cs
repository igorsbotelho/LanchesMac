using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lanches",
                columns: new[]
                {
            "LancheId", "Nome", "DescricaoCurta", "DescricaoDetalhada", "Preco",
            "ImagemUrl", "ImagemThumbnailUrl", "IsLanchePreferido", "EmEstoque", "CategoriaId"
                },
                values: new object[,]
                {
            {
                1, "Cheeseburger",
                "Pão, carne e queijo deliciosos",
                "Um cheeseburger clássico com pão fresco, carne suculenta e queijo derretido.",
                19.99m,
                "https://example.com/cheeseburger.jpg",
                "https://example.com/cheeseburger_thumbnail.jpg",
                true, 50, 1
            },
            {
                2, "Sanduíche Natural",
                "Uma opção leve e saudável",
                "Sanduíche com pão integral, peito de peru, alface, tomate e molho especial.",
                14.99m,
                "https://example.com/sanduiche.jpg",
                "https://example.com/sanduiche_thumbnail.jpg",
                false, 30, 2
            },
            {
                3, "Hot Dog",
                "O melhor cachorro-quente da região",
                "Pão macio com salsicha, queijo, molho especial e acompanhamentos.",
                12.50m,
                "https://example.com/hotdog.jpg",
                "https://example.com/hotdog_thumbnail.jpg",
                true, 25, 1
            }
                }
            );
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
