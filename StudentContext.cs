using System.Data.Entity;

namespace CodeFirstStudentApp
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}