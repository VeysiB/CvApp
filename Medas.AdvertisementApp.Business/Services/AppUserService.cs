using AutoMapper;
using FluentValidation;
using Medas.AdvertisementApp.Business.Interfaces;
using Medas.AdvertisementApp.Dtos.AppUserDtos;
using Medas.AdvirsementApp.DataAccess.UnitOfWork;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Services
{
    public class AppUserService:Service<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>,IAppUserService
    {
        public AppUserService(IMapper mapper,IValidator<AppUserCreateDto> createDtoValidator,IValidator<AppUserUpdateDto> updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {
            
        }
    }
}
