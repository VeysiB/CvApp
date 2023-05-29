using AutoMapper;
using FluentValidation;
using Medas.AdvertisementApp.Business.Extensions;
using Medas.AdvertisementApp.Business.Interfaces;
using Medas.AdvertisementApp.Common;
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
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<AppUserCreateDto> _createDtoValidator;
        public AppUserService(IMapper mapper,IValidator<AppUserCreateDto> createDtoValidator,IValidator<AppUserUpdateDto> updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {
            _uow= uow;
            _mapper= mapper;
            _createDtoValidator= createDtoValidator;
        }
        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto,int roleId)
        {
            var validationResult=_createDtoValidator.Validate(dto);
            if(validationResult.IsValid)
            {
                var user = _mapper.Map<AppUser>(dto);
                await _uow.GetRepository<AppUser>().CreateAsync(user);
                await _uow.GetRepository<AppUserRole>().CreateAsync(new AppUserRole
                {
                    AppUser = user,
                    AppRoleId = roleId
                });
                await _uow.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
            }
            return new Response<AppUserCreateDto>(dto,validationResult.ConvertToCustomValidationError());
        }
    }
}
