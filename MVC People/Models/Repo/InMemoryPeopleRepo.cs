namespace MVC_People.Models.Repo
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {



        private static  List<Person> ListOfPeople = new List<Person>();
        private static int IdCounter = 0;

        //Adding person
        public Person Add(Person person)
        {
            person.Id = ++IdCounter;
            ListOfPeople.Add(person);
            return person;

        }

        //Showing all person
        public List<Person> All()
        {
            return ListOfPeople;
        }


        public List<Person> Read(string CityName)
        {
           List<Person> ListForCityInMemory = new List<Person>();
           foreach (Person aPerson in ListForCityInMemory) 
            {
                if(aPerson.CityName == CityName)
                {
                    ListForCityInMemory.Add(aPerson);
                }
            }
           return ListForCityInMemory;
        }

        public Person Read(int id)
        {
            Person? person = null;
            foreach (Person aPerson in ListOfPeople) 
            {
                if (aPerson.Id == id)
                {
                    return aPerson;
                   
                }
            }
            return person;
            
        }

        //Updating the details
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

     
      
    }
}
