using Repository.Base;
using Repository.Entity.Model;
using Repository.Model;

namespace Repository.DataClass.Abstraction.CatalogueData
{
    public interface ICatalogueData : IBaseRepository<CatalogueDataEntity>
    {
        public Task<IEnumerable<CatalogueDataDomain>> GetAll();
    }
}
