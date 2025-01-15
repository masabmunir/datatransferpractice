using Microsoft.EntityFrameworkCore;

namespace datatransferpractice.Models
{
    public class TeacherDBContext : DbContext
    {
        public TeacherDBContext( DbContextOptions options) :base(options)
        {
                
        }

       public DbSet<Teacher> Teachers { get; set; }   
    }
}
