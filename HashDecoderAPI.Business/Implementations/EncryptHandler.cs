using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using HashDecoderAPI.Contracts.DTO.Request;
using HashDecoderAPI.Contracts.DTO.Response;
namespace HashDecoderAPI.Business.Implementations
{
    public class EncryptHandler : IRequestHandler<EncryptRequest, EncryptResponse>
    {

        public Task<EncryptResponse> Handle(EncryptRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new EncryptResponse
            {
                Result = new EncryptDto
                {
                    Result = ConvertHandler.EncryptString(request.Data,request.Passphrase)
                }
            });
        }
    }
}
