using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        { 
        RuleFor(x=>x.WriterName).NotEmpty().WithMessage("yazar adını boş geçemezsin");
        RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("yazar soy boş geçemesin");
        RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("yazar hakkında boş geçemesin");
        RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("yazar hakkında boş geçemesin");
        RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("lütfen en az 3 karekter girişi yapın");
        RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
        }
    }
}
