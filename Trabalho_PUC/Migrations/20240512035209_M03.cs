using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho_PUC.Migrations
{
    /// <inheritdoc />
    public partial class M03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhysicalMoney",
                table: "PhysicalMoney");

            migrationBuilder.RenameTable(
                name: "PhysicalMoney",
                newName: "PhysicalMoneys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhysicalMoneys",
                table: "PhysicalMoneys",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhysicalMoneys",
                table: "PhysicalMoneys");

            migrationBuilder.RenameTable(
                name: "PhysicalMoneys",
                newName: "PhysicalMoney");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhysicalMoney",
                table: "PhysicalMoney",
                column: "Id");
        }
    }
}
