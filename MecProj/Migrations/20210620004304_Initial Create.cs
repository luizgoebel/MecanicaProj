using Microsoft.EntityFrameworkCore.Migrations;

namespace MecProj.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Servicos_OrdemServicoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_OrdemServicoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "OrdemServicoId",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Cliente",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Servicos");

            migrationBuilder.AddColumn<int>(
                name: "OrdemServicoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_OrdemServicoId",
                table: "Clientes",
                column: "OrdemServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Servicos_OrdemServicoId",
                table: "Clientes",
                column: "OrdemServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
