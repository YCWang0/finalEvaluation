using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YCW.ClientInfoSystem.Core.ServiceInterface;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YCW.ClientInfoSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IClientsService _clientsService;
        public HomeController (IClientsService clientsService)
        {
            _clientsService = clientsService;
        }
        [HttpGet]
        [Route("allClients")]
        public async Task<ActionResult> GetAllClients()
        {
            var cli = await _clientsService.GetAllClients();
            return Ok(cli);
        }
        [HttpGet]
        [Route("client/{id:int}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var cli = await _clientsService.GetClientsById(id);
            return Ok(cli);
        }
        [HttpPost]
        [Route("newClient")]
        public async Task<IActionResult> CreateClient(Clients client)
        {
            var cli = await _clientsService.CreateClients(client);
            return Ok(cli);
        }
        [HttpPost]
        [Route("updateClient")]
        public async Task<IActionResult> UpdateClient(Clients clients)
        {
            var cli = await _clientsService.UpdateClients(clients);
            return Ok(cli);
        }
        //use post http request to delete the client
        [HttpPost]
        [Route("deleteClient")]
        public async Task<IActionResult> DeleteClient(Clients clients)
        {
            await _clientsService.DeleteClients(clients);
            return Ok();
        }

    }
}
