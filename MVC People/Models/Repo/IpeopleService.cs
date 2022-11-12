namespace MVC_People.Models.Repo
{
    public interface IpeopleService
    {

        Person Add(CrestePersonViewModel person);

        List<Person> GetAll();

        List<Person> FindById(string search);

        List<Person> FindById(int id);

        bool Edit(int id, CrestePersonViewModel person);

        bool Remove(int id);

    }
}
