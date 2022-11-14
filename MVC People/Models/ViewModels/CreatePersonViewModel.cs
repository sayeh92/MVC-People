using System.ComponentModel.DataAnnotations;

namespace MVC_People.Models.ViewModels
{
    public class CreatePersonViewModel
    {
           
        [Display(Name = "Person")]
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? CityName { get; set; }
    }
}
