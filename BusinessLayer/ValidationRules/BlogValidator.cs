using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).MinimumLength(30).WithMessage("Blog içeriği minimum 30 karakter olmalıdır.");
            RuleFor(x => x.BlogContent).MaximumLength(4000).WithMessage("Blog içeriği maksimum 4000 karakter olmalıdır.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş bırakamazsınız.");
            RuleFor(x => x.BlogTitle).MaximumLength(75).WithMessage("Maksimum 75 karakter kullanarak başlık koyabilirsiniz.");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Minimum 4 karakter kullanarak başlık koyabilirsiniz.");

        }
    }
}
