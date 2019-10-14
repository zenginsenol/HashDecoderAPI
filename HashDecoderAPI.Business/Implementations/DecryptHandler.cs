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
    public class DecryptHandler : IRequestHandler<DecryptRequest, DecryptResponse>
    {

        public Task<DecryptResponse> Handle(DecryptRequest request, CancellationToken cancellationToken)
        {
            var retVal = ConvertHandler.DecryptString(request.Data, request.Passphrase);
            
            return Task.FromResult(new DecryptResponse
            {
                Result = new DecryptDto
                {
                    Result = JsonConvert.SerializeObject(retVal)
                }
            });
        }
    }
}
