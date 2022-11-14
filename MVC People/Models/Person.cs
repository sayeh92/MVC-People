using Microsoft.AspNetCore.Identity;

namespace MVC_People.Models
{
    public class Person

    
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CityName { get; set; }
    }
}
