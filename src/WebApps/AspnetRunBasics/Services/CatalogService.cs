using AspnetRunBasics.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRunBasics.Services
{
    public class CatalogService : ICatalogService
    {
        public async Task<CatalogModel> CreateCatalog(CatalogModel model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalog()
        {
            throw new System.NotImplementedException();
        }

        public async Task<CatalogModel> GetCatalog(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category)
        {
            throw new System.NotImplementedException();
        }
    }
}
