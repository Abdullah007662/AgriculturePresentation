using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x=> x.AddressDescription1).NotEmpty().WithMessage("Açıklama 1 Boş Geçilemez!");
            RuleFor(x => x.AddressDescription1).MaximumLength(30).WithMessage("Açıklama Uzunlugu 30 Karakterden Fazla Olamaz");
            RuleFor(x => x.AddressDescription2).MaximumLength(30).WithMessage("Açıklama Uzunlugu 30 Karakterden Fazla Olamaz");
            RuleFor(x => x.AddressDescription3).MaximumLength(30).WithMessage("Açıklama Uzunlugu 30 Karakterden Fazla Olamaz");
            RuleFor(x => x.AddressDescription4).MaximumLength(30).WithMessage("Açıklama Uzunlugu 30 Karakterden Fazla Olamaz");
            RuleFor(x => x.AddressDescription2).NotEmpty().WithMessage("Açıklama 2 Boş Geçilemez!");
            RuleFor(x => x.AddressDescription3).NotEmpty().WithMessage("Açıklama 3 Boş Geçilemez");
            RuleFor(x => x.AddressDescription4).NotEmpty().WithMessage("Açıklama 4 Boş Geçilemez!");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Harita Bilgisi Boş Geçilemez!");
        }
    }
}
