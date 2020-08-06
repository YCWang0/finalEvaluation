using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YCW.ClientInfoSystem.Core.ServiceInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }
        [HttpGet]
        [Route("allEmployees")]
        public async Task<ActionResult> GetAllEmployees()
        {
            var emp = await _employeesService.GetAllEmployees();
            return Ok(emp);
        }
        [HttpGet]
        [Route("employee/{id:int}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var emp = await _employeesService.GetEmployeesById(id);
            return Ok(emp);
        }
        [HttpPost]
        [Route("newEmployee")]
        public async Task<IActionResult> CreateEmployee(Employees employees)
        {
            var emp = await _employeesService.CreateEmployees(employees);
            return Ok(emp);
        }
        [HttpPost]
        [Route("updateEmployee")]
        public async Task<IActionResult>UpdateEmployee(Employees employees)
        {
            var emp = await _employeesService.UpdateEmployees(employees);
            return Ok(emp);
        }
        [HttpPost]
        [Route("deleteEmployee")]
        public async Task<IActionResult>DeleteEmployee(Employees employees)
        {
            await _employeesService.DeleteEmployees(employees);
            return Ok();
        }



    }
}
