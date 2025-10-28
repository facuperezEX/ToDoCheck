using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proyecto4programacion.Migrations
{
    /// <inheritdoc />
    public partial class addEstadoEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Tarea",
                newName: "Estado1");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Tarea",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_EstadoId",
                table: "Tarea",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Estados_EstadoId",
                table: "Tarea",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Estados_EstadoId",
                table: "Tarea");

            migrationBuilder.DropIndex(
                name: "IX_Tarea_EstadoId",
                table: "Tarea");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Tarea");

            migrationBuilder.RenameColumn(
                name: "Estado1",
                table: "Tarea",
                newName: "Estado");
        }
    }
}
