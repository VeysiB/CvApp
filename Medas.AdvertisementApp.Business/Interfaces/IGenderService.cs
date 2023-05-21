using Medas.AdvertisementApp.Dtos.GenderDtos;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService:IService<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>
    {
    }
}
