using AutoMapper;
using Medas.AdvertisementApp.Dtos.AdvertisementDtos;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Mappings
{
    public class AdvertisementProfile:Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<Advertisement, AdvertisementListDto>().ReverseMap();
            CreateMap<Advertisement,AdvertisementCreateDto>().ReverseMap();
            CreateMap<Advertisement,AdvertisementUpdateDto>().ReverseMap();
        }
    }
}
