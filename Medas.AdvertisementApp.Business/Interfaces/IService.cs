using Medas.AdvertisementApp.Common;
using Medas.AdvertisementApp.Dtos.Interfaces;
using Medas.AdvertisementApp.Dtos.ProvidedServiceDtos;
using Medas.AdvirsementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.Interfaces
{
    public interface IService<CreateDto,UpdateDto,ListDto,T>
        where CreateDto : class,IDto,new()
        where UpdateDto : class,IUpdateDto,new()
        where ListDto : class,IDto,new()
        where T:BaseEntity
    {

        Task<IResponse<CreateDto>> CreateAsync(CreateDto dto);
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto dto);
        Task<IResponse<IDto>> GetByIdAsync(int id);
        Task<IResponse> RemoveAsync(int id);
        Task<IResponse<List<ListDto>>> GetAllAsync();
    }
}
