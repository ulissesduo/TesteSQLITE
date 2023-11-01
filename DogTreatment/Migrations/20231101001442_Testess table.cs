using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogTreatment.Migrations
{
    /// <inheritdoc />
    public partial class Testesstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Testess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testess",
                table: "Testess",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testess",
                table: "Testess");

            migrationBuilder.RenameTable(
                name: "Testess",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
