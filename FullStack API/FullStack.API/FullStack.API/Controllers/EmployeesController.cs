using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStack.API.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {

        public EmployeesController()
        {

        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    Phone = 1234567890,
                    Salary = 5000,
                    Department = "IT"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    Email = "janesmith@example.com",
                    Phone = 9876543210,
                    Salary = 6000,
                    Department = "Finance"
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "Alex Johnson",
                    Email = "alexjohnson@example.com",
                    Phone = 5555555555,
                    Salary = 4500,
                    Department = "Marketing"
                }
            };
            return Ok(employees);
        }
    }
}