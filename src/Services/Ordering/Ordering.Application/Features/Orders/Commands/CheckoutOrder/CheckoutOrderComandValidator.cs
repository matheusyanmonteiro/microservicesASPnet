using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderComandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderComandValidator() { }
    }
}
