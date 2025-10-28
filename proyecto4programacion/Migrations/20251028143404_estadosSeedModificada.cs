using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto4programacion.Migrations
{
    /// <inheritdoc />
    public partial class estadosSeedModificada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descripcion",
                value: "Completada");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descripcion",
                value: "Cumplido");
        }
    }
}
