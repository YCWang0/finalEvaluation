using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;
using YichenWang.applicaiton.ClientInformationSystem.Infa.Data;

namespace YCW.ClientInfoSystem.Infa.Repositories
{
    public class ClientsRepository :EfRepository<Clients>,IClientsRepository
    {
        public ClientsRepository(YCWClientInfoSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Clients>> GetAllClients()
        {
            var clis = await _dbContext.Clients.OrderBy(c => c.Id).ToListAsync();
            return clis;
        }
    }
}
