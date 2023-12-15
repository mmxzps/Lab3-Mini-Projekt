using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3_Mini_Projekt.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestWebLinks_Interests_InterestId",
                table: "InterestWebLinks");

            migrationBuilder.RenameColumn(
                name: "InterestId",
                table: "InterestWebLinks",
                newName: "InterestsId");

            migrationBuilder.RenameIndex(
                name: "IX_InterestWebLinks_InterestId",
                table: "InterestWebLinks",
                newName: "IX_InterestWebLinks_InterestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestWebLinks_Interests_InterestsId",
                table: "InterestWebLinks",
                column: "InterestsId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestWebLinks_Interests_InterestsId",
                table: "InterestWebLinks");

            migrationBuilder.RenameColumn(
                name: "InterestsId",
                table: "InterestWebLinks",
                newName: "InterestId");

            migrationBuilder.RenameIndex(
                name: "IX_InterestWebLinks_InterestsId",
                table: "InterestWebLinks",
                newName: "IX_InterestWebLinks_InterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestWebLinks_Interests_InterestId",
                table: "InterestWebLinks",
                column: "InterestId",
                principalTable: "Interests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
