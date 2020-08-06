using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Core.ServiceInterface
{
    public interface IInteractionsService
    {
        Task<IEnumerable<Interactions>> GetAllInteractions();
        Task<Interactions> GetInteractionsById(int id);
        Task<IEnumerable<Interactions>> GetAllInteractionsByEmpId(int empId);
        Task<IEnumerable<Interactions>> GetAllInteractionsByClientId(int empId);
        Task<Interactions> CreateInteractions(Interactions interactions);
        Task<Interactions> UpdateInteractions(Interactions interactions);
        Task DeleteInteractions(Interactions interactions);
    }
}
