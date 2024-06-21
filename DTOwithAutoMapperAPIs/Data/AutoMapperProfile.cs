using AutoMapper;

namespace DTOwithAutoMapperAPIs.Data
{
    //Inherited from profile
    public class AutoMapperProfile : Profile
    {
        //Add Constructor
        public AutoMapperProfile()
        {
            //add source and destination in < source, Destination>
            CreateMap<SuperHero, SuperHeroDTO>();

            //second method Mapping Create Method
            CreateMap<SuperHeroDTO, SuperHero>();

        }
    }
}
