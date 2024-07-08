using AutoMapper;
using Repository.Entity.Model;
using Repository.Model;

namespace Repository.Configuration
{
    public class AutoMapperRepositoryConfig : Profile
    {
        public AutoMapperRepositoryConfig()
        {
            CreateMap<CatalogueDataDomain, CatalogueDataEntity>().ReverseMap();
        }
    }
}
