using System;
using System.Collections.Generic;
using System.Text;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;
using YichenWang.applicaiton.ClientInformationSystem.Infa.Data;

namespace YCW.ClientInfoSystem.Infa.Repositories
{
    public class EmployeesRepository: EfRepository<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(YCWClientInfoSystemDbContext dbContext) : base(dbContext)
        {

        }

    }
}
