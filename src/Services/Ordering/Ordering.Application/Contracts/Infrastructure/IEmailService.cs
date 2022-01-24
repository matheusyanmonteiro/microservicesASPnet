
using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructure
{
    interface IEmailService
    {
        Task<bool> SendEmail(Email emai);
    }
}
