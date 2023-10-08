using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("İsim bölümü boş geçilemez.");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail bölümü boş geçilemez.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre bölümü boş geçilmez.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapabilirsiniz.");
		}
	}
}

