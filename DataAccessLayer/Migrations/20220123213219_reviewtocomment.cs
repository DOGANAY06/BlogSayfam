using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class reviewtocomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewID",
                table: "Comments",
                column: "ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewID",
                table: "Comments",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reviews_ReviewID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ReviewID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Comments");
        }
    }
}
