﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
       public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemesiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
        }
    }
}
