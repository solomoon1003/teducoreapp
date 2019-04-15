using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeduCoreApp.Data.Entities;
using TeduCoreApp.Infrastructure.Interfaces;

namespace TeduCoreApp.Data.IRepository
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        Task<List<ProductCategory>> GetByAlias(string alias);
    }
}
