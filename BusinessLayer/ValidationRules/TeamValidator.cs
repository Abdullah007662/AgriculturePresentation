using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Ad Soyad Boş Olamaz");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Az Veri Girişi Yapınız");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakterden Oluşan Veri Girişi Yapınız");
            RuleFor(x => x.PersonTitle).NotEmpty().WithMessage("Görev Kısmı Boş Geçilmez");
            RuleFor(x => x.PersonTitle).MaximumLength(50).WithMessage("Personel Görevi 50 Karakterden Fazla Olamaz");
            RuleFor(x => x.PersonTitle).MinimumLength(5).WithMessage("Personel Görevi 5 Karakterden Az Olamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Boş Geçilemez");
        }
    }
}