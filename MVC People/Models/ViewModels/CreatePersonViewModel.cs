using System.ComponentModel.DataAnnotations;

namespace MVC_People.Models.ViewModels
{
    public class CreatePersonViewModel
    {
       
        [Required]
        public int Id { get; set; }

        [Display(Name = "Person")]
        [Required]
        public string? Name { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string? CityName { get; set; }
    }
}
