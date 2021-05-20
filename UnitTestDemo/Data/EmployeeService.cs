using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestDemo.Models;

namespace UnitTestDemo.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext _context;

        public EmployeeService(EmployeeContext context)
        {
            _context = context;
        }

        public async Task<string> GetEmployeeById(int id)
        {
            var name = await _context.Employees.Where(c => c.Id == id).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var emp = await _context.Employees.FirstOrDefaultAsync(c => c.Id == id);
            return emp;
        }
    }
}
