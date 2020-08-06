using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.Core.RepositoryInterface
{
    public interface IClientsRepository:IAsyncRepository<Clients>
    {
        Task<IEnumerable<Clients>> GetAllClients();
    }
}
