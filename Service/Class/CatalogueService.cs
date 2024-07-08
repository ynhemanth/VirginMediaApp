using AutoMapper;
using Repository.DataClass.Abstraction.CatalogueData;
using Service.Abstraction;
using Service.Model;

namespace Service.Class
{
    public class CatalogueService : ICatalogueService
    {
        private readonly IMapper _mapper;
        private readonly ICatalogueData _catalogueData;

        public CatalogueService(ICatalogueData catalogueData, IMapper mapper) 
        {
            _mapper = mapper;
            _catalogueData = catalogueData;
        }
        public async Task<IEnumerable<CatalogueDataCore>> GetAll()
        {
            var result = await _catalogueData.GetAll();
            var data = _mapper.Map<IEnumerable<CatalogueDataCore>>(result);

            return data;
        }
    }
}
