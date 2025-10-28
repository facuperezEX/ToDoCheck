using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto4programacion.Migrations
{
    /// <inheritdoc />
    public partial class removeEstadoString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado1",
                table: "Tarea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado1",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
