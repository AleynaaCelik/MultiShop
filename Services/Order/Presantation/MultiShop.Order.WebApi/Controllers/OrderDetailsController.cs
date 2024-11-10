using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

namespace MultiShop.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly GetOrderDetailQueryHandler _getOrderDetailQueryHandler;
        private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler;
        private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler;
        private readonly RemoveOrderDetailQueryHandler _removeOrderDetailCommandHandler;
        private readonly IUpdateOrderDetailCommandHandler _updateOrderDetailCommandHandler;

        public OrderDetailsController(
            IGetOrderDetailQueryHandler getOrderDetailQueryHandler,
        IGetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler,
            ICreateOrderDetailCommandHandler createOrderDetailCommandHandler,
            IRemoveOrderDetailCommandHandler removeOrderDetailCommandHandler,
            IUpdateOrderDetailCommandHandler updateOrderDetailCommandHandler)
        {
            _getOrderDetailQueryHandler = getOrderDetailQueryHandler;
            _getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
            _createOrderDetailCommandHandler = createOrderDetailCommandHandler;
            _removeOrderDetailCommandHandler = removeOrderDetailCommandHandler;
            _updateOrderDetailCommandHandler = updateOrderDetailCommandHandler;
        }
    }
}
