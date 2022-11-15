namespace MVC_People.Models.Repo
{
    public interface IPeopleRepo
    {
        //CREATE
        public Person Add(Person person);
        //READ
        public List<Person> All();
        public List<Person> Read(string CityName);

        public Person Read(int id);

      
        //UPDATE
        public bool Update (Person person);

        //DELETE
        public bool Delete(Person  person);

      
    }
}
