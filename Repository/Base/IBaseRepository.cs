using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Base
{
    public interface IBaseRepository<T>
    {  
        Task<IEnumerable<T>> GetAllAsync();        
    }
}
