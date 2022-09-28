

using ASP_HW3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_HW3.DBContext
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> contextOptions)
           : base(contextOptions)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
