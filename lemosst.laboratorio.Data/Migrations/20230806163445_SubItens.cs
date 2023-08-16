using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lemosst.laboratorio.Data.Migrations
{
    /// <inheritdoc />
    public partial class SubItens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubItensId",
                table: "ProdutoItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SubItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubItens", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoItens_SubItensId",
                table: "ProdutoItens",
                column: "SubItensId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoItens_SubItens_SubItensId",
                table: "ProdutoItens",
                column: "SubItensId",
                principalTable: "SubItens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoItens_SubItens_SubItensId",
                table: "ProdutoItens");

            migrationBuilder.DropTable(
                name: "SubItens");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoItens_SubItensId",
                table: "ProdutoItens");

            migrationBuilder.DropColumn(
                name: "SubItensId",
                table: "ProdutoItens");
        }
    }
}
