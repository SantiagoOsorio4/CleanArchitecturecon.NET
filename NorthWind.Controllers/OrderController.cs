using MediatR;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Presenters;
using NorthWind.UseCasesDTOs.CreateOrder;

namespace NorthWind.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OrderController
    {
        readonly IMediator Mediator;
        public OrderController(IMediator mediator) =>
            Mediator = mediator;

        [HttpPost("create-order")]
        public async Task<string> CreateOrder(
            CreateOrderParams orderparams)
        {
            CreateOrderPresenter
        }

    }
}