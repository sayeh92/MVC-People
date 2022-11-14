namespace MVC_People.Models.Repo
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {



        private static  List<Person> ListOfPeople = new List<Person>();
        private static int IdCounter = 0;

        public Person Add(Person person)
        {
            person.Id = ++IdCounter;
            ListOfPeople.Add(person);
            return person;

        }
      
       
        public List<Person> Read()
        {
            return ListOfPeople;
        }

        public Person Read(int id)
        {
        
            foreach (Person aPerson in ListOfPeople) 
            {
                if (aPerson.Id == id)
                {
                    return aPerson;
                   
                }
            }
            return null;
            
        }

        public bool Update(Person person)
        {
            Person orginalPerson = Read(person.Id);
            if (orginalPerson != null)
            {
                orginalPerson.Name = person.Name;
                orginalPerson.PhoneNumber = person.PhoneNumber;
                orginalPerson.CityName = person.CityName;
                return true;
            }

            return false;
        }

        public bool Delete(Person person)
        {
            if (person != null)
            {
                ListOfPeople.Remove(person); return true;
            }
            return false;
        }

        public List<Person> All()
        {
            return ListOfPeople;
        }
    }
}
