using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz!")]
        public string? userName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz!")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Lütfen Mail  Giriniz!")]
        public string? mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar  Giriniz!")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil,Kontrol Edin!")]
        public string? PasswordConfirm { get; set; }

    }
}
