using AutoMapper;
using FluentValidation;
using Medas.AdvertisementApp.Business.Interfaces;
using Medas.AdvertisementApp.Dtos.GenderDtos;
using Medas.AdvirsementApp.DataAccess.UnitOfWork;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Services
{
    public class GenderService:Service<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>,IGenderService
    {
        public GenderService(IMapper mapper,IValidator<GenderCreateDto> createDtoValidator,IValidator<GenderUpdateDto> updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {
            
        }
    }
}
