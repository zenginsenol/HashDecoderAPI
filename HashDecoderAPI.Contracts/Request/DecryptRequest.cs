using MediatR;
using HashDecoderAPI.Contracts.DTO.Response;

namespace HashDecoderAPI.Contracts.DTO.Request
{
    public class DecryptRequest : IRequest<DecryptResponse>
    {
        public string Data { get; set; }
        public string Passphrase { get; set; }
    }
}
