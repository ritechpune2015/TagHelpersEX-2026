using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;

namespace TagHelpersEX.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string CityName { get; set; }
        public Int64   CategoryID { get; set; }
        public bool IsActive { get; set; }
        public RoleEnum Role { get; set; }
    }
}
