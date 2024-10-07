using ControllersUnitTesting2_.Models;
using ControllersUnitTesting2_.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControllersUnitTesting2_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }
        private IActionResult Get() => Ok(_clientService.GetAll());


        [HttpGet]

        public ActionResult<IEnumerable<Client>> GetClients()
        {
            IEnumerable<Client> clients = _clientService.GetAll();
            return Ok(clients);
        }
    }
}
