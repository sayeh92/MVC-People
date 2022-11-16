using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;

namespace MVC_People.Models
{
    public class Person


    {
              //public Person(string? name, string? phoneNumber, string? cityName)
              //{
              //   Name = name;
              //   PhoneNumber = phoneNumber;
              //   CityName = cityName;
              //}

            
              public int Id { get; set; }
              public string? Name { get; set; }
              public string? PhoneNumber { get; set; }
              public string? CityName { get; set; }
         }
}
