using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Daw.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantityToUserProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "UserProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "UserProducts");
        }
    }
}
