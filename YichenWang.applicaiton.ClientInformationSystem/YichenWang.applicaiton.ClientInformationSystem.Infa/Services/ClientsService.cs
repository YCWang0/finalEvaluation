using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YCW.ClientInfoSystem.Core.ServiceInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Infa.Services
{
    public class ClientsService:IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        public ClientsService(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        public async Task<Clients> CreateClients(Clients clients)
        {
            return await _clientsRepository.AddAsync(clients);
        }

        //return null
        public async Task DeleteClients(Clients clients)
        {
             await _clientsRepository.DeleteAsync(clients);
        }

        public async Task<IEnumerable<Clients>> GetAllClients()
        {
            var clis = await _clientsRepository.ListAllAsync();
            return clis;
        }

        public async Task<Clients> GetClientsById(int id)
        {
            var cli = await _clientsRepository.GetByIdAsync(id);
            return cli;
        }

        public async Task<Clients> UpdateClients(Clients clients)
        {
            var cli = await _clientsRepository.UpdateAsync(clients);
            return cli;
        }
    }
}
