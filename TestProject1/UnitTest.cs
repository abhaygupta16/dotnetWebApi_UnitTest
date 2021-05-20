using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestDemo.Controllers;
using UnitTestDemo.Data;
using UnitTestDemo.Models;
using Xunit;

namespace TestProject1
{
    public class UnitTest
    {
        #region Property  
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeeById()
        {
            mock.Setup(p => p.GetEmployeeById(1)).ReturnsAsync("Abhay");
            EmployeesController emp = new EmployeesController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("Abhay", result);
            Assert.NotEqual("abc", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "Abhay",
                Desgination = "Manager"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeesController emp = new EmployeesController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
            //Assert.Equal("Manager", result.Desgination);
        }
    }
}
