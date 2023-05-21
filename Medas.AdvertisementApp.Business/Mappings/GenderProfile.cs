using AutoMapper;
using Medas.AdvertisementApp.Dtos.GenderDtos;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Mappings
{
    public class GenderProfile:Profile
    {
        public GenderProfile()
        {
            CreateMap<Gender,GenderCreateDto>().ReverseMap();
            CreateMap<Gender,GenderUpdateDto>().ReverseMap();
            CreateMap<Gender, GenderListDto>().ReverseMap();
        }
    }
}
