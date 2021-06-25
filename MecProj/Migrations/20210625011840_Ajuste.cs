using Microsoft.EntityFrameworkCore.Migrations;

namespace MecProj.Migrations
{
    public partial class Ajuste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Razão_Social",
                table: "Empresa",
                newName: "Razao_Social");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Razao_Social",
                table: "Empresa",
                newName: "Razão_Social");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
