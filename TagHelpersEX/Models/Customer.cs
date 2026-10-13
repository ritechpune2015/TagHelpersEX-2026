using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace TagHelpersEX.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; }
    }
}
