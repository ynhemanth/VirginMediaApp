using AutoMapper;
using Repository.Base;
using Repository.DataClass.Abstraction.CatalogueData;
using Repository.Entity.Model;
using Repository.Model;

namespace Repository.DataClass
{
    public class CatalogueData : BaseRepository<CatalogueDataEntity>, ICatalogueData
    {
        private readonly IMapper _mapper;
        
        public CatalogueData(IMapper mapper) 
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<CatalogueDataDomain>> GetAll()
        {
            var data = await GetAllAsync();
            var result = _mapper.Map<IEnumerable<CatalogueDataDomain>>(data);

            return result;

        }
    }
}
