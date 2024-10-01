using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.ImageTitle).NotEmpty().WithMessage("Görsel Başlığını Boş Geçemezsiniz!");
            RuleFor(x => x.ImageTitle).MaximumLength(25).WithMessage("Başlık 25 Karakterden Fazla Olamaz");
            RuleFor(x => x.ImageTitle).MinimumLength(8).WithMessage("Başlık 8 Karakterden Az Olamaz");
            RuleFor(x => x.ImageDescription).NotEmpty().WithMessage("Görsel Açıklamasını Boş Geçemezsiniz!");
            RuleFor(x => x.ImageDescription).MaximumLength(50).WithMessage("Açıklama En Fazla 50 Karakter Olabilir");
            RuleFor(x => x.ImageDescription).MinimumLength(20).WithMessage("Açıklama En Az 20 Karakter Olabilir");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolunu Boş Geçemezsiniz!");
        }
    }
}
