using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaUpdateDTO,VillaDTO>().ReverseMap();
            CreateMap<VillaCreateDTO,VillaDTO>().ReverseMap();
            CreateMap<VillaNumberDTO,VillaNumberUpdateDTO>().ReverseMap();
            CreateMap<VillaNumberUpdateDTO,VillaNumberDTO>().ReverseMap();
           

        }
    }
}
