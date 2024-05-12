using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho_PUC.Migrations
{
    /// <inheritdoc />
    public partial class M02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_gastofisicos",
                table: "gastofisicos");

            migrationBuilder.RenameTable(
                name: "gastofisicos",
                newName: "PhysicalMoney");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhysicalMoney",
                table: "PhysicalMoney",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhysicalMoney",
                table: "PhysicalMoney");

            migrationBuilder.RenameTable(
                name: "PhysicalMoney",
                newName: "gastofisicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gastofisicos",
                table: "gastofisicos",
                column: "Id");
        }
    }
}
