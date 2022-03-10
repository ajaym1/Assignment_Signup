using Assignment1.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models
{
    public class SignUpModel
    {        
       
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        

        [Required(ErrorMessage ="Please Enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[@#$%^&+=]).{6,}$", ErrorMessage = "Password should be atleast six characters long and must have at least one Uppercase letter, number and special characters")]
        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please Enter Confirm Password")]

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }
        [RegularExpression("^[6789]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string ContactNo { get; set; }

        
        [Required(ErrorMessage = "Please Select Country")]
        public string Country { get; set; }

        
        [Required(ErrorMessage = "Please Select City")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Please Select Gender")]
        public string Gender { get; set; }
        
        [Display(Name ="Accept Terms")]
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }

        public List<SelectListItem> GetCityByCountryId(int countryId)
        {
            List<SelectListItem> cityList = new List<SelectListItem>();

            if (countryId == 1)
            {
                cityList = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Agra", Value = "1" }  ,
                    new SelectListItem{Text="Budaun", Value = "2" }  ,
                    new SelectListItem{Text="Delhi", Value = "3" }
                };
            }
            else if (countryId == 2)
            {
                cityList = new List<SelectListItem>()
                {
                    new SelectListItem{Text="New York", Value="1"},
                    new SelectListItem{Text="Los Angeles", Value="2"}
                };
            }            
            return cityList;
        }

    }
   
}
