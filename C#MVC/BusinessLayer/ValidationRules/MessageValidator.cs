using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {

            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı mail Adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsin");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı adını boş geçemesiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.MessageContent).MinimumLength(10).WithMessage("lütfen en az 3 karekter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");

        }

    }
}
