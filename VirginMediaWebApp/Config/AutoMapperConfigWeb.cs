using AutoMapper;
using Repository.Model;
using Service.Model;
using VirginMediaWebApp.Models;

namespace VirginMediaWebApp.Config
{
    public class AutoMapperConfigWeb : Profile
    {
        public AutoMapperConfigWeb() 
        {
            CreateMap<CatalogueDataWeb , CatalogueDataCore>().ReverseMap();
        }
    }
}
