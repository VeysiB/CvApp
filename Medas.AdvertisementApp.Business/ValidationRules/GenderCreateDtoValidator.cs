using FluentValidation;
using Medas.AdvertisementApp.Dtos.GenderDtos;

namespace Medas.AdvertisementApp.Business.ValidationRules
{
    public class GenderCreateDtoValidator:AbstractValidator<GenderCreateDto>
    {
        public GenderCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
        }
    }
}
