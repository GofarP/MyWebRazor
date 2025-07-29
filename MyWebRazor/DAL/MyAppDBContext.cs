using Microsoft.EntityFrameworkCore;
using MyWebRazor.Model;

namespace MyWebRazor.DAL
{
    public class MyAppDBContext : DbContext
    {
        public MyAppDBContext(DbContextOptions<MyAppDBContext> options) : base(options)
        {
                
        }

        public DbSet<Books> Books { get; set; }

    }
}
