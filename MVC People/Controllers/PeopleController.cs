﻿using Microsoft.AspNetCore.Mvc;
using MVC_People.Models.Repo;
using MVC_People.Models.Services;
using MVC_People.Models.ViewModels;
using NuGet.Protocol;
using System.Net;
using System;
using Microsoft.AspNetCore.Identity;
using MVC_People.Models;

namespace MVC_People.Controllers
{
    public class PeopleController : Controller
    {
        IpeopleService _peopleService;
        public PeopleController ()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }



        public IActionResult PersonPage()
        {
            return View(_peopleService.All());
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View(new CreatePersonViewModel());
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Add(CreatePersonViewModel addPerson) 
        {
         if (ModelState.IsValid) 
            {
             try
                {
                    _peopleService.Add(addPerson);
                }
                catch (ArgumentException exception)
                {
                    ModelState.AddModelError("Name and CityName", exception.Message);
                    return View(addPerson);
                }

                //after adding the person, with this line of code it goes back to the whole list, 
                //otherwise it will stay in the same form and you can not see the information you submitted.
                return RedirectToAction(nameof(PersonPage));  
            }
            return View(addPerson);
        }

        //Details Button
        public IActionResult Details(int id) 
        {
         Person person = _peopleService.FindById(id);

            if (person == null) 
            {
                return RedirectToAction(nameof(PersonPage));    
            }

            return View(person);
        }

        //Edit Button
        [HttpGet]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(int id)
        {
            Person person = _peopleService.FindById(id);
            if (person == null)
            {
                return RedirectToAction(nameof(PersonPage));
            }
            CreatePersonViewModel editPerson = new CreatePersonViewModel();
            {
                
                editPerson.Name = person.Name;
                editPerson.PhoneNumber = person.PhoneNumber;
                editPerson.CityName = person.CityName;
            }
            return View(editPerson);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Edit(int id,CreatePersonViewModel editPerson)
        {
            if (ModelState.IsValid) 
            {
            _peopleService.Edit(id, editPerson);
                return RedirectToAction(nameof(PersonPage));
            }
            _peopleService.Add(editPerson);
            return View(editPerson);
        }

        //Delete Button
        public IActionResult Delete(int id)
        {

            Person person = _peopleService.FindById(id);

            if (person == null)
            {
                return RedirectToAction(nameof(PersonPage));
            }
            else
            {
                _peopleService.Remove(id);
            }

            return View(person);

        }

       
       
    }
}
