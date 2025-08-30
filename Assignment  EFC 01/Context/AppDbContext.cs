using Microsoft.EntityFrameworkCore;
namespace Assignment__EFC_01

{
    internal class AppDbContext : DbContext
    {

        public AppDbContext() : base() 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=APP01;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses   { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }



    }
}
