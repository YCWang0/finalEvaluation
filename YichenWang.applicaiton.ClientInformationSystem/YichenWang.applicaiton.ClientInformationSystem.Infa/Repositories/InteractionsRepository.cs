using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCW.ClientInfoSystem.Core.RepositoryInterface;
using YCW.ClientInfoSystem.Infa.Models;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;
using YichenWang.applicaiton.ClientInformationSystem.Infa.Data;

namespace YCW.ClientInfoSystem.Infa.Repositories
{
    public class InteractionsRepository:EfRepository<Interactions>,IInteractionsRepository
    {
        public InteractionsRepository(YCWClientInfoSystemDbContext dbContext) : base(dbContext)
        {

        }

        public Task<IEnumerable<Interactions>> GetAllInteractionsByClientId(int clientId)
        {
            var ints = _dbContext.Interactions.Where(ci => ci.ClientId == clientId).Include(m => m.Clients).Select(i => i.Clients);
            return (Task<IEnumerable<Interactions>>)ints;
        }

        public Task<IEnumerable<Interactions>> GetAllInteractionsByEmpId(int empId)
        {
            var ints = _dbContext.Interactions.Where(ci => ci.ClientId == empId).Include(m => m.Clients).Select(i => i.Clients);
            return (Task<IEnumerable<Interactions>>)ints;
        }


    }
}
