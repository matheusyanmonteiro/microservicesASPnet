using Basket.API.Entities;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        public readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

        public async Task DeleteBasket(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<ShoppingCart> GetBasket(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<ShoppingCart> UpdateBasket(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
