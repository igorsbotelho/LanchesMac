using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNameCarrinhoCompraId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinnhoCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinhoCompraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                newName: "CarrinnhoCompraId");
        }
    }
}
