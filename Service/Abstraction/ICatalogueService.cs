using Service.Model;

namespace Service.Abstraction
{
    public interface ICatalogueService
    {
        public Task<IEnumerable<CatalogueDataCore>> GetAll();
    }
}
