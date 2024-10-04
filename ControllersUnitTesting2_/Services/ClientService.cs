using ControllersUnitTesting2_.Models;

namespace ControllersUnitTesting2_.Services
{
    public class ClientService : IClientService
    {
        public List<Client> _clients;

        public ClientService()
        {
            _clients = new List<Client>
            {
                new Client{Id=1, Name="Pedro", Money=1500, User="pedro_"},
                 new Client{Id=2, Name="Lorena", Money=2000, User="Lore.B"},
                  new Client{Id=3, Name="Enzo", Money=3500, User="eenzo"}
            };
        }
        public IEnumerable<Client> GetAll() => _clients;

        public Client GetById(int id) => _clients[id];
    }
}
