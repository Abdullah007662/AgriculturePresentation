using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz!")]
        public string? kullanıcıAdı { get; set; }

        [Required(ErrorMessage ="Lütfen Şifreyi Giriniz!")]
        public string? şifre { get; set; }

    }
}
