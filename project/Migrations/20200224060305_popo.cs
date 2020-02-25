using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class popo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pies_CourseId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Pies",
                newName: "courses");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Pies_CategoryId",
                table: "courses",
                newName: "IX_courses_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Category_CategoryId",
                table: "courses",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_courses_CourseId",
                table: "OrderDetails",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_Category_CategoryId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_courses_CourseId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Pies");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_courses_CategoryId",
                table: "Pies",
                newName: "IX_Pies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pies_CourseId",
                table: "OrderDetails",
                column: "CourseId",
                principalTable: "Pies",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
