using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<courses> Courses { get; set; }
        //public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderdetails> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(" Server = (localdb)\\mssqllocaldb; Database =UdemyDatabse; Trusted_Connection = True; MultipleActiveResultSets = true");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 1,
                CategoryName = "Development",
                Description = "Development Courses",
              
            });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Business" , Description ="Courses related to Business"  });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "IT and Software" });
           
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 1,
                Name = "HTML",
                Price = 500,
                ShortDescription = "Fundamentals Of Html",
                LongDescription =
                  "Hypertext Markup Language is the standard markup language for documents designed to be displayed in a web browser. It can be assisted by technologies such as Cascading Style Sheets and scripting languages such as JavaScript",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                
               
            });

            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 2,
                Name = "CSS",
                Price = 700,
                ShortDescription = "Fundamentals Of CSS",
                LongDescription =
                  "Cascading Style Sheets is a style sheet language used for describing the presentation of a document written in a markup language like HTML. CSS is a cornerstone technology of the World Wide Web.",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 3,
                Name = "JAVASCRIPT",
                Price = 800,
                ShortDescription = "Fundamentals Of jAVASCRIPT",
                LongDescription =
                 "JavaScript, often abbreviated as JS, is an interpreted programming language that conforms to the ECMAScript specification. JavaScript is high-level, often just-in-time compiled, and multi-paradigm.",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 4,
                Name = "Complete Financial Analyst Course",
                Price = 500,
                ShortDescription = "Complete Financial Analyst Course",
                LongDescription =
                 "Excel, Accounting, Financial Statement Analysis, Business Analysis, Financial Math, PowerPoint: Everything is Included!",
                CategoryId = 2,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 5,
                Name = "Tableau 10",
                Price = 600,
                ShortDescription = "Hands-On Tableau Training For Data Science!",
                LongDescription =
                 "Learn Tableau 10 for Data Science step-by-step. Real-Life Data Analytics Exercises & Quizzes Included. Learn by doing!",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 6,
                Name = " Complete Investment Banking Course",
                Price = 700,
                ShortDescription = " Complete Investment Banking Course",
                LongDescription =
                 "The #1 Course to Land a Job in Investment Banking. IPOs, Bonds, M&A, Trading, LBOs, Valuation: Everything is included!",
                CategoryId = 2,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 7,
                Name = "AWS Certified Solutions Architect",
                Price = 500,
                ShortDescription = "AWS Certified Solutions Architect",
                LongDescription =
                 "Want to pass the AWS Solutions Architect - Associate Exam? Want to become Amazon Web Services Certified? Do this course!",
                CategoryId = 3,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 8,
                Name = " Ethical Hacking",
                Price = 700,
                ShortDescription = "",
                LongDescription =
                 "",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });
            modelBuilder.Entity<courses>().HasData(new courses
            {
                CourseId = 9,
                Name = "CSS",
                Price = 700,
                ShortDescription = "Fundamentals Of CSS",
                LongDescription =
                 "",
                CategoryId = 1,
                ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",


            });

        }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<courses> Course { get; set; }
        //public DbSet<Category> Category { get; set; }

    }
}