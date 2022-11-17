﻿using MVC_People.Models.Repo;
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
            Person person = _peopleRepo.Add(addperson.Name, addperson.PhoneNumber, addperson.CityName);
            if (string.IsNullOrWhiteSpace(addperson.Name) ||
                string.IsNullOrWhiteSpace(addperson.CityName) ||
                string.IsNullOrWhiteSpace(addperson.PhoneNumber))
            { throw new ArgumentException("Name, CityName, PhoneNumber Not allowed WhiteSpace"); }
            //Person person = new();
            //{

            //    person.Name = addperson.Name;
            //    person.PhoneNumber = addperson.PhoneNumber;
            //    person.CityName = addperson.CityName;

            //}
            //person = _peopleRepo.Add(person);
            return person;
        }

        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            Person OriginalPerson = FindById(id);
            if (OriginalPerson != null)
            {
                OriginalPerson.Name = editPerson.Name;
                OriginalPerson.CityName = editPerson.CityName;
                OriginalPerson.PhoneNumber = editPerson.PhoneNumber;
            }
            return _peopleRepo.Update(OriginalPerson);
        }



        public Person FindById(int id)
        {
            return _peopleRepo.Read(id);
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public bool Remove(int id)
        {
            Person DeletePerson = _peopleRepo.Read(id);
            bool Done = _peopleRepo.Delete(DeletePerson);
            return Done;
        }


        public List<Person> Search(string search)
        {

            throw new NotImplementedException();
            //list<person> searchperson = new _peoplerepo.read();
        }

    }
}
