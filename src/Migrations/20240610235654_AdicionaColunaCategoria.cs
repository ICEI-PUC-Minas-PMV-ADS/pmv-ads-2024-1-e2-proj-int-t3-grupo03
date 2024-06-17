using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kippa.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaColunaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Lembrete",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Lembrete");
        }
    }
}
