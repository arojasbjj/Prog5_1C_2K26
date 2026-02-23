using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog5_1C_2K26.Migrations
{
    /// <inheritdoc />
    public partial class AddNombreToSintoma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Sintomas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Sintomas");
        }
    }
}
