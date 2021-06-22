using Microsoft.EntityFrameworkCore.Migrations;

namespace MecProj.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedore",
                table: "Fornecedore");

            migrationBuilder.RenameTable(
                name: "Fornecedore",
                newName: "Fornecedor");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedore_CNPJ",
                table: "Fornecedor",
                newName: "IX_Fornecedor_CNPJ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fornecedor",
                table: "Fornecedor");

            migrationBuilder.RenameTable(
                name: "Fornecedor",
                newName: "Fornecedore");

            migrationBuilder.RenameIndex(
                name: "IX_Fornecedor_CNPJ",
                table: "Fornecedore",
                newName: "IX_Fornecedore_CNPJ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fornecedore",
                table: "Fornecedore",
                column: "Id");
        }
    }
}
