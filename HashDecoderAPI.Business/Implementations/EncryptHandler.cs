using System;
using System.ServiceModel.Description;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using HashDecoderAPI.Contracts.DTO.Request;
using HashDecoderAPI.Contracts.DTO.Response;
using Newtonsoft.Json;

namespace HashDecoderAPI.Business.Implementations
{
    public class EncryptHandler : IRequestHandler<EncryptRequest, EncryptResponse>
    {

        public Task<EncryptResponse> Handle(EncryptRequest request, CancellationToken cancellationToken)
        {
            var retVal = ConvertHandler.EncryptString(request.Data, "d123");
            
            return Task.FromResult(new EncryptResponse
            {
                Result = new EncryptDto
                {
                    Result = JsonConvert.SerializeObject(retVal)
                }
            });
        }
    }
}
