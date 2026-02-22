using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog5_1C_2K26.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPersonaSintomaTipoVacuna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoVacuna",
                table: "TipoVacuna");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sintoma",
                table: "Sintoma");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CentroVacunacion",
                table: "CentroVacunacion");

            migrationBuilder.RenameTable(
                name: "TipoVacuna",
                newName: "TipoVacunas");

            migrationBuilder.RenameTable(
                name: "Sintoma",
                newName: "Sintomas");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "CentroVacunacion",
                newName: "CentrosVacunacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoVacunas",
                table: "TipoVacunas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sintomas",
                table: "Sintomas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentrosVacunacion",
                table: "CentrosVacunacion",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoVacunas",
                table: "TipoVacunas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sintomas",
                table: "Sintomas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CentrosVacunacion",
                table: "CentrosVacunacion");

            migrationBuilder.RenameTable(
                name: "TipoVacunas",
                newName: "TipoVacuna");

            migrationBuilder.RenameTable(
                name: "Sintomas",
                newName: "Sintoma");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "CentrosVacunacion",
                newName: "CentroVacunacion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoVacuna",
                table: "TipoVacuna",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sintoma",
                table: "Sintoma",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentroVacunacion",
                table: "CentroVacunacion",
                column: "id");
        }
    }
}
