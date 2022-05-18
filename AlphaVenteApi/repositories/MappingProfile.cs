using AlphaVenteApi.Models.Dtos;
using AlphaVenteData.model;
using AutoMapper;

namespace AlphaVenteApi.repositories
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            

        }
    }
}
