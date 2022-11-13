namespace MVC_People.Models.Repo
{
    public interface IPeopleRepo
    {
        //I changed the Create to Add
        Person Add(Person person);

        List<Person> Read();

        Person Read(int id);
                 
        bool Update (Person person);

        bool Delete(Person  person);

        List<Person> All();
    }
}
