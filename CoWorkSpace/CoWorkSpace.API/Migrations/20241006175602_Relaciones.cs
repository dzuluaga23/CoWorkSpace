using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoWorkSpace.API.Migrations
{
    /// <inheritdoc />
    public partial class Relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspacioId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MiembroId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventoId",
                table: "Inscripcions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MiembroId",
                table: "Inscripcions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EspacioId",
                table: "Asignacions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecursoId",
                table: "Asignacions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EspacioId",
                table: "Reservas",
                column: "EspacioId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_MiembroId",
                table: "Reservas",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcions_EventoId",
                table: "Inscripcions",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcions_MiembroId",
                table: "Inscripcions",
                column: "MiembroId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignacions_EspacioId",
                table: "Asignacions",
                column: "EspacioId");

            migrationBuilder.CreateIndex(
                name: "IX_Asignacions_RecursoId",
                table: "Asignacions",
                column: "RecursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignacions_Espacios_EspacioId",
                table: "Asignacions",
                column: "EspacioId",
                principalTable: "Espacios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignacions_Recursos_RecursoId",
                table: "Asignacions",
                column: "RecursoId",
                principalTable: "Recursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcions_Eventos_EventoId",
                table: "Inscripcions",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripcions_Miembros_MiembroId",
                table: "Inscripcions",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Espacios_EspacioId",
                table: "Reservas",
                column: "EspacioId",
                principalTable: "Espacios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Miembros_MiembroId",
                table: "Reservas",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignacions_Espacios_EspacioId",
                table: "Asignacions");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignacions_Recursos_RecursoId",
                table: "Asignacions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcions_Eventos_EventoId",
                table: "Inscripcions");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripcions_Miembros_MiembroId",
                table: "Inscripcions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Espacios_EspacioId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Miembros_MiembroId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_EspacioId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_MiembroId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Inscripcions_EventoId",
                table: "Inscripcions");

            migrationBuilder.DropIndex(
                name: "IX_Inscripcions_MiembroId",
                table: "Inscripcions");

            migrationBuilder.DropIndex(
                name: "IX_Asignacions_EspacioId",
                table: "Asignacions");

            migrationBuilder.DropIndex(
                name: "IX_Asignacions_RecursoId",
                table: "Asignacions");

            migrationBuilder.DropColumn(
                name: "EspacioId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "MiembroId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "Inscripcions");

            migrationBuilder.DropColumn(
                name: "MiembroId",
                table: "Inscripcions");

            migrationBuilder.DropColumn(
                name: "EspacioId",
                table: "Asignacions");

            migrationBuilder.DropColumn(
                name: "RecursoId",
                table: "Asignacions");
        }
    }
}
