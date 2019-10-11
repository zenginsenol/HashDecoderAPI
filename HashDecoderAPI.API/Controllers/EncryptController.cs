using System.Threading.Tasks;
using HashDecoderAPI.Contracts.DTO.Request;
using HashDecoderAPI.Contracts.DTO.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HashDecoderAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EncryptController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("")]
        public Task<EncryptResponse> Encrypt([FromForm] EncryptRequest request) =>
            _mediator.Send(request);
        
    }
}