using AlphaVenteData.model;
using AutoMapper;

namespace AlphaVenteApi.Dtos
{
    public class CustomerDto:IMapFrom
    {
        public int Id { get; set; }
        public string? codeClient { get; set; }
        public string? FullName { get; set; }
        public string? adress { get; set; }
        public string? email { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
