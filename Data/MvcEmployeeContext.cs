using Microsoft.EntityFrameworkCore;
using Project2.Models;

namespace CMPG323Project2.Data
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext(DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}