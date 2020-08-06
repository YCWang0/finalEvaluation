using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YCW.ClientInfoSystem.Core.ServiceInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Infa.Services
{
    public class InteractionsService : IInteractionsService
    {
        private readonly IInteractionsRepository _interactionsRepository;
        public InteractionsService(IInteractionsRepository interactionsRepository)
        {
            _interactionsRepository = interactionsRepository;
        }
        public async Task<IEnumerable<Interactions>> GetAllInteractions()
        {
            var ints= await _interactionsRepository.ListAllAsync();
            return ints;
        }

        public async Task<Interactions> GetInteractionsById(int id)
        {
            var ints = await _interactionsRepository.GetByIdAsync(id);
            return ints; 
        }

        public async Task<IEnumerable<Interactions>> GetAllInteractionsByEmpId(int empId)
        {
            var ints = await _interactionsRepository.GetAllInteractionsByEmpId(empId);
            return ints;
        }

        public async Task<IEnumerable<Interactions>> GetAllInteractionsByClientId(int clientId)
        {
            var ints = await _interactionsRepository.GetAllInteractionsByClientId(clientId);
            return ints;
        }

        public async Task<Interactions> CreateInteractions(Interactions interactions)
        {
            var ints = await _interactionsRepository.AddAsync(interactions);
            return ints;
        }

        public async Task<Interactions> UpdateInteractions(Interactions interactions)
        {
            var ints = await _interactionsRepository.UpdateAsync(interactions);
            return ints;
        }

        public async Task DeleteInteractions(Interactions interactions)
        {
             await _interactionsRepository.DeleteAsync(interactions);
            
        }

        
    }
}
