using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photoo_Students_Studentid",
                table: "Photoo");

            migrationBuilder.RenameColumn(
                name: "Studentid",
                table: "Photoo",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Photoo_Studentid",
                table: "Photoo",
                newName: "IX_Photoo_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photoo_Students_StudentId",
                table: "Photoo",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photoo_Students_StudentId",
                table: "Photoo");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Photoo",
                newName: "Studentid");

            migrationBuilder.RenameIndex(
                name: "IX_Photoo_StudentId",
                table: "Photoo",
                newName: "IX_Photoo_Studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Photoo_Students_Studentid",
                table: "Photoo",
                column: "Studentid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
