using AutoMapper;
using Medas.AdversimentApp.UI.Models;
using Medas.AdvertisementApp.Dtos.AppUserDtos;

namespace Medas.AdversimentApp.UI.Mapping
{
    public class UserCreateModelProfile:Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel,AppUserCreateDto>().ReverseMap();
        }
    }
}
