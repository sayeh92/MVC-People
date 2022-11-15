using MVC_People.Models.Repo;
using MVC_People.Models.ViewModels;
namespace MVC_People.Models.Services
{
    public class PeopleService : IpeopleService
    {

        IPeopleRepo _peopleRepo;
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }
        public Person Add(CreatePersonViewModel addperson)
        {
            if (string.IsNullOrWhiteSpace(addperson.Name) || 
                string.IsNullOrWhiteSpace(addperson.CityName) || 
                string.IsNullOrWhiteSpace(addperson.PhoneNumber)) 
            { throw new ArgumentException("Name, CityName, PhoneNumber Not allowed WhiteSpace"); }
            Person person= new Person();
            {
                
                person.Name= addperson.Name;
                person.PhoneNumber= addperson.PhoneNumber;
                person.CityName= addperson.CityName;

            }
            person = _peopleRepo.Add(person);
            return person;
        }

        public bool Edit(int id, CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public List<Person> Search(string search)
        {
            throw new NotImplementedException();
        }

        public Person FindById(int id)
        {
            return _peopleRepo.Read(id);
        }

        public List<Person> All()
        {
            return _peopleRepo.All();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
