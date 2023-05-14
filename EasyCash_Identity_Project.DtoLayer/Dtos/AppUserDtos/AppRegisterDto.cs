using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.DtoLayer.Dtos.AppUserDtos
{
    public class AppRegisterDto
    {
        //[Required(ErrorMessage = "Ad alanı zorunludur")] // Validasyon Zorunlu alanlar doğrulama.
        //[Display(Name="İsim:")]                           //Arka tarafta görülen isim için 
        //[MaxLength(30,ErrorMessage ="En fazla 30 karakter girebilirsiniz")]  //Max Karakter sayısı
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
    }
}
//ad soyad, username,mail,password,confirmpassword
