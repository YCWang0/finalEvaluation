using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Core.RepositoryInterface
{
    public interface IInteractionsRepository:IAsyncRepository<Interactions>
    {
        Task<IEnumerable<Interactions>> GetAllInteractionsByEmpId(int empId);
        Task<IEnumerable<Interactions>> GetAllInteractionsByClientId(int cilentId);
    }

}
