using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestDemo.Data;
using UnitTestDemo.Models;

namespace UnitTestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int id)
        {
            var empname = await _service.GetEmployeeById(id);
            return empname;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int id)
        {
            var emp = await _service.GetEmployeeDetails(id);
            return emp;
        }


    }
}
