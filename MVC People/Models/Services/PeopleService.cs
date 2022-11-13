using MVC_People.Models.ViewModels;
namespace MVC_People.Models.Services
{
    public class PeopleService : IpeopleService
    {
        public Person Add(CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public bool Edit(int id, CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindById(string search)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
