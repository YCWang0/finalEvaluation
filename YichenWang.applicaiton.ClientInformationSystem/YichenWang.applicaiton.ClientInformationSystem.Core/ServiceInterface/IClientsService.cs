using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Core.ServiceInterface
{
    public interface IClientsService 
    {
        Task<IEnumerable<Clients>> GetAllClients();
        Task<Clients> GetClientsById(int id);
        Task<Clients> CreateClients(Clients clients);
        Task<Clients> UpdateClients(Clients clients);
        Task DeleteClients(Clients clients);

    }
}
