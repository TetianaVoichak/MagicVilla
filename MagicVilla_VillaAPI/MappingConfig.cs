using AutoMapper;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
              //transfer data from an object of type Villa to an object of type VillaDTO
              CreateMap<Villa, VillaDTO>();
              CreateMap<VillaDTO, Villa>();
              //transfer and inverse 
              CreateMap<Villa, VillaCreateDTO>().ReverseMap();
              CreateMap<Villa, VillaUpdateDTO>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
      
    }
}
