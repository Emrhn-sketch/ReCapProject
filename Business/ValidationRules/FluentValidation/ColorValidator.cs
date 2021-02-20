using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.ColorName).NotEmpty();
        }
    }
}
