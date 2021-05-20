using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestDemo.Models;

namespace UnitTestDemo.Data
{
    public interface IEmployeeService
    {

        Task<string> GetEmployeeById(int id);
        Task<Employee> GetEmployeeDetails(int id);
    }
}
