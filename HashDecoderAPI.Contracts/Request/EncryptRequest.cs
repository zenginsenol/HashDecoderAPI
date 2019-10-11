using MediatR;
using HashDecoderAPI.Contracts.DTO.Response;

namespace HashDecoderAPI.Contracts.DTO.Request
{
    public class EncryptRequest : IRequest<EncryptResponse>
    {
        
        public string Operation { get; set; }
        public string Data { get; set; }
        public string Passphrase { get; set; }
    }
}
