namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
            Id = "25",
            Name = "Maria Ahle",
            Email = "maria@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "Kantinen"
            }
            },
            new Employee() {
                Id = "25",
                Name = "Emma Delic",
                Email = "emma@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "Kantinen"
                }
            },
            new Employee() {
                Id = "25",
                Name = "Jonathan",
                Email = "jonathan@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "IT"
                }
            },
            new Employee() {
                Id = "25",
                Name = "Luwam",
                Email = "luwam@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "IT"
                }
            }
            };
            return employees;
        }
    }


}