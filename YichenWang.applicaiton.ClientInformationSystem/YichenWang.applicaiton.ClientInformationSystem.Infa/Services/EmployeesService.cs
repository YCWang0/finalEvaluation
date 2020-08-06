using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YCW.ClientInfoSystem.Core.ServiceInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Infa.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesService (IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }
        public async Task<Employees> CreateEmployees(Employees employees)
        {
            return await _employeesRepository.AddAsync(employees);
        }

        public async Task DeleteEmployees(Employees employees)
        {
            await _employeesRepository.DeleteAsync(employees);
        }

        public async Task<IEnumerable<Employees>> GetAllEmployees()
        {
            var emp = await _employeesRepository.ListAllAsync();
            return emp;
        }

        public async Task<Employees> GetEmployeesById(int id)
        {
            var emp = await _employeesRepository.GetByIdAsync(id);
            return emp;
        }

        public async Task<Employees> UpdateEmployees(Employees employees)
        {
            var emp = await _employeesRepository.UpdateAsync(employees);
            return emp;
        }
    }
}
