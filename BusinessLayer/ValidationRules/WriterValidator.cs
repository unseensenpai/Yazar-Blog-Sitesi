using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer> // Fluent validation kullanabilmek için Abstract Validatorden miras aldı.
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş bırakılamaz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakterli isim giriniz.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakterli isim giriniz.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş bırakılamaz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında kısmı boş bırakılamaz.");
        }
    }
}
