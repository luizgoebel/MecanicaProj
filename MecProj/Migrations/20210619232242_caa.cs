using Microsoft.EntityFrameworkCore.Migrations;

namespace MecProj.Migrations
{
    public partial class caa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Clientes_ClienteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ClienteId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servicos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "OrdemServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_ClienteId",
                table: "Clientes",
                newName: "IX_Clientes_OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Servicos_OrdemServicoId",
                table: "Clientes",
                column: "OrdemServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Servicos_OrdemServicoId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "OrdemServicoId",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_OrdemServicoId",
                table: "Clientes",
                newName: "IX_Clientes_ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ClienteId",
                table: "Servicos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Clientes_ClienteId",
                table: "Clientes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
