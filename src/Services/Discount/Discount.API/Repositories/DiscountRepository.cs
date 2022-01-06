using Discount.API.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Discount.API.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly IConfiguration _configuration;

        public DiscountRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<bool> CreateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<Coupon> GetDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateDiscount(Coupon coupon)
        {
            throw new NotImplementedException();
        }
    }
}
