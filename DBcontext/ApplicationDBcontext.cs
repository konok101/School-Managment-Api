using Microsoft.EntityFrameworkCore;
using School_Managment.Model;

namespace School_Managment.DBcontext
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options) { }
        public DbSet<Student> studentInfo { get; set; }

    }
}
