using DemoProjectMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.DbCon
{
    public class MVCContext:DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options) : base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
