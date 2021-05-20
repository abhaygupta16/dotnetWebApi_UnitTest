using Microsoft.EntityFrameworkCore;
using UnitTestDemo.Models;

namespace UnitTestDemo.Data
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> opt):base(opt)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
