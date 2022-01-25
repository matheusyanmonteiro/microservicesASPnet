using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Persistence;

using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class PublicOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        public readonly IOrderRepository _orderRepository;
        public readonly IMapper _mapper;
        public readonly ILogger<PublicOrderCommandHandler> _logger;

        public Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
