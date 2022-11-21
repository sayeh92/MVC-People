﻿namespace MVC_People.Models.Repo
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {



        private static  List<Person> ListOfPeople = new List<Person>();
        private static int IdCounter = 0;

        //Adding person
        public Person Add(string name, string phonenumber, string cityname)
        {
            Person person = new Person(name, phonenumber, cityname);
            person.Id = ++IdCounter;
            person.Name= name;
            person.PhoneNumber = phonenumber;
            person.CityName = cityname;
            ListOfPeople.Add(person);
            return person;

        }

        //Showing all person
        public List<Person> Read()
        {
            return ListOfPeople;
        }


        //public List<Person> ReadByCity(string cityname)
        //{
        //    List<Person> listforcityinmemory = new List<Person>();
        //    foreach (Person aperson in listforcityinmemory)
        //    {
        //        if (aperson.CityName == cityname)
        //        {
        //            listforcityinmemory.Add(aperson);
        //        }
        //    }
        //    return listforcityinmemory;
        //}

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
                ListOfPeople.Remove(person);
                return true;
            }
            return false;
        }

        public List<Person> ReadByCity(string cityname)
        {
            List<Person> ListOfPeople = new List<Person>();
            foreach (Person aperson in ListOfPeople)
            {
                if (aperson.CityName == cityname)
                {
                    ListOfPeople.Add(aperson);
                }
            }
            return ListOfPeople;
        }

        //public List<Person> ReadByCity()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
