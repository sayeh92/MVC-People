using Microsoft.AspNetCore.Identity;

namespace MVC_People.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int PhoneNumber { get; set; }
        public string? CityName { get; set; }
    }
}
