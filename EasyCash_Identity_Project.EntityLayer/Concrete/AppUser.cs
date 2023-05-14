using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>  //Birincil Anahtar belirleme.
    {
        public string  Name { get; set; } //Müşteri İsmi 
        public string Surname { get; set; } //Müşteri Soyismi
        public string District { get; set; } //Müşteri Ilçe 
        public string City { get; set; } //Müşteri Sehir
        public string ImageUrl { get; set; } //Müşteri Resmi 
        public List<CustomerAccount> CustomerAccounts { get; set; }




    }
}
