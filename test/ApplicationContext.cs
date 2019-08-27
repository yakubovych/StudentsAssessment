using System.Data.Entity;

namespace test
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DbConnection") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}