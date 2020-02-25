using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Pies",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pies", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Pies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    PieId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CourseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Pies_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Pies",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Development", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Business", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "IT and Software", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "CourseId", "CategoryId", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "Hypertext Markup Language is the standard markup language for documents designed to be displayed in a web browser. It can be assisted by technologies such as Cascading Style Sheets and scripting languages such as JavaScript", "HTML", 500m, "Fundamentals Of Html" },
                    { 2, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "Cascading Style Sheets is a style sheet language used for describing the presentation of a document written in a markup language like HTML. CSS is a cornerstone technology of the World Wide Web.", "CSS", 700m, "Fundamentals Of CSS" },
                    { 3, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "JavaScript, often abbreviated as JS, is an interpreted programming language that conforms to the ECMAScript specification. JavaScript is high-level, often just-in-time compiled, and multi-paradigm.", "JAVASCRIPT", 800m, "Fundamentals Of jAVASCRIPT" },
                    { 5, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "Learn Tableau 10 for Data Science step-by-step. Real-Life Data Analytics Exercises & Quizzes Included. Learn by doing!", "Tableau 10", 600m, "Hands-On Tableau Training For Data Science!" },
                    { 8, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "", " Ethical Hacking", 700m, "" },
                    { 9, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "", "CSS", 700m, "Fundamentals Of CSS" },
                    { 4, 2, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "Excel, Accounting, Financial Statement Analysis, Business Analysis, Financial Math, PowerPoint: Everything is Included!", "Complete Financial Analyst Course", 500m, "Complete Financial Analyst Course" },
                    { 6, 2, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "The #1 Course to Land a Job in Investment Banking. IPOs, Bonds, M&A, Trading, LBOs, Valuation: Everything is included!", " Complete Investment Banking Course", 700m, " Complete Investment Banking Course" },
                    { 7, 3, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", "Want to pass the AWS Solutions Architect - Associate Exam? Want to become Amazon Web Services Certified? Do this course!", "AWS Certified Solutions Architect", 500m, "AWS Certified Solutions Architect" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CourseId",
                table: "OrderDetails",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Pies_CategoryId",
                table: "Pies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Pies");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
