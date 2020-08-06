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
    public class InteractionsController : ControllerBase
    {
        private readonly IInteractionsService _interactionsService;
        public InteractionsController(IInteractionsService interactionsService)
        {
            _interactionsService = interactionsService;
        }

        [HttpGet]
        [Route("InteractionsByClientId/{id:int}")]
        public async Task<IActionResult> GetInteractionsByClientId(int id)
        {
            var ints = await _interactionsService.GetInteractionsById(id);
            return Ok(ints);
        }
        [HttpGet]
        [Route("InteractionsByEmpId/{id:int}")]
        public async Task<IActionResult> GetInteractionsByEmpId(int id)
        {
            var ints = await _interactionsService.GetInteractionsById(id);
            return Ok(ints);
        }
        [HttpGet]
        [Route("Allinteractions")]
        public async Task<IActionResult> GetAlllInteractions()
        {
            var ints = await _interactionsService.GetAllInteractions();
            return Ok(ints);
        }
        [HttpPost]
        [Route("newInteractions")]
        public async Task<IActionResult> CreateInteractions(Interactions interactions)
        {
            var ints = await _interactionsService.CreateInteractions(interactions);
            return Ok(ints);
        }
        [HttpPost]
        [Route("updateInteraction")]
        public async Task<IActionResult> UpdateInteraction(Interactions interactions)
        {
            var ints = await _interactionsService.UpdateInteractions(interactions);
            return Ok(ints);
        }
        [HttpPost]
        [Route("deleteClient")]
        public async Task<IActionResult> DeleteInteraction(Interactions interactions)
        {
            await _interactionsService.DeleteInteractions(interactions);
            return Ok();
        }


    }
}
