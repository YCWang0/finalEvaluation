using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Core.ServiceInterface
{
    public interface IEmployeesService
    {
      
            Task<IEnumerable<Employees>> GetAllEmployees();
            Task<Employees> GetEmployeesById(int id);
            Task<Employees> CreateEmployees(Employees employees);
            Task<Employees> UpdateEmployees(Employees employees);
            Task DeleteEmployees(Employees employees);

        
    }
}
