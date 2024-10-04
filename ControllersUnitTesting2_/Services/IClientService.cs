using ControllersUnitTesting2_.Models;

namespace ControllersUnitTesting2_.Services
{
    public interface IClientService
    {
        public IEnumerable<Client> GetAll();
        public Client GetById(int id);
    }
}
