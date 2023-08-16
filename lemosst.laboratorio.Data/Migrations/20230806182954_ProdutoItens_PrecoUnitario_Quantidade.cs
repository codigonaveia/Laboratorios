using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lemosst.laboratorio.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProdutoItens_PrecoUnitario_Quantidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecoUnitario",
                table: "ProdutoItens",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "Quantidade",
                table: "ProdutoItens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "ProdutoItens");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "ProdutoItens");
        }
    }
}
