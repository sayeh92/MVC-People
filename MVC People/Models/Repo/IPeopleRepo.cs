namespace MVC_People.Models.Repo
{
    public interface IPeopleRepo
    {
      
        public Person Add(Person person);

        public List<Person> Read();

        public Person Read(int id);

        public bool Update (Person person);

        public bool Delete(Person  person);

        public List<Person> All();
    }
}
