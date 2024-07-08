using AutoMapper;
using Repository.Model;
using Service.Model;

namespace Service.Configuration
{
    public class AutoMapperServiceConfig : Profile
    {
        public AutoMapperServiceConfig() 
        {
            CreateMap<CatalogueDataCore, CatalogueDataDomain>().ReverseMap();
        }
    }
}
