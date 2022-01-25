using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryID",
                table: "Reviews",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Categories_CategoryID",
                table: "Reviews",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Categories_CategoryID",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_CategoryID",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Reviews");
        }
    }
}
