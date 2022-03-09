using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Type_Children_ChildId",
                table: "Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Type",
                table: "Type");

            migrationBuilder.RenameTable(
                name: "Type",
                newName: "Toy");

            migrationBuilder.RenameIndex(
                name: "IX_Type_ChildId",
                table: "Toy",
                newName: "IX_Toy_ChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toy",
                table: "Toy",
                column: "ToyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Toy_Children_ChildId",
                table: "Toy",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "ChildId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Toy_Children_ChildId",
                table: "Toy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toy",
                table: "Toy");

            migrationBuilder.RenameTable(
                name: "Toy",
                newName: "Type");

            migrationBuilder.RenameIndex(
                name: "IX_Toy_ChildId",
                table: "Type",
                newName: "IX_Type_ChildId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Type",
                table: "Type",
                column: "ToyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Type_Children_ChildId",
                table: "Type",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "ChildId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
