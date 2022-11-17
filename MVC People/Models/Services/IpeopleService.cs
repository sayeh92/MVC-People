﻿using MVC_People.Models.ViewModels;
namespace MVC_People.Models.Services
{
    public interface IpeopleService
    {

        Person Add(CreatePersonViewModel addPerson);

        List<Person> All();

        List<Person> Search(string search);

        Person FindById(int id);

        bool Edit(int id, CreatePersonViewModel editPerson);

        bool Remove(int id);

    }
}
