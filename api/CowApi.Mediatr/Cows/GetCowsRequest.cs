using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CowApi.Models.Cows;
using CowApi.Services;

namespace CowApi.Mediatr.Cows
{
    public class GetCowsRequest : IRequest<GetCowsResponse>
    {
    }

    public class GetCowsResponse
    {
        public List<Cow> Cows { get; set; }
    }

    public class GetCowsHandler : IRequestHandler<GetCowsRequest, GetCowsResponse>
    {
        private readonly ICowsService _cowsService;

        public GetCowsHandler(ICowsService cowsService)
        {
            _cowsService = cowsService;
        }

        public Task<GetCowsResponse> Handle(GetCowsRequest request, CancellationToken cancellationToken)
        {
            // Gets all the cows
            var response = new GetCowsResponse
            {
                Cows = _cowsService.GetAllCows()
            };

            return Task.FromResult(response);
        }
    }
}
