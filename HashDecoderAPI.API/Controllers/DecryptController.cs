using System.Threading.Tasks;
using HashDecoderAPI.Contracts.DTO.Request;
using HashDecoderAPI.Contracts.DTO.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HashDecoderAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecryptController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DecryptController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public Task<DecryptResponse> Decrypt([FromForm] DecryptRequest request) =>
            _mediator.Send(request);
        
    }
}