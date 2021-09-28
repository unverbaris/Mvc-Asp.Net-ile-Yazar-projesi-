using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        //kısa yolu ctor tab tabb
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("kategöri adını boş geçemezsin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("açıklamayı boş geçemesin");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
        }
    }
}
