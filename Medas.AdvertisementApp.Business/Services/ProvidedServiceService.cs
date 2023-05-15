using AutoMapper;
using FluentValidation;
using Medas.AdvertisementApp.Business.Interfaces;
using Medas.AdvertisementApp.Common;
using Medas.AdvertisementApp.Dtos.ProvidedServiceDtos;
using Medas.AdvirsementApp.DataAccess.UnitOfWork;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto, ProvidedServiceUpdateDto,ProvidedServiceListDto, ProvidedService>, IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper,IValidator<ProvidedServiceCreateDto> createDtoValidator,IValidator<ProvidedServiceUpdateDto> updateDtoValidator,IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow) 
        {
            
        }

        
    }
}
