using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using CowApi.Mediatr.Cows;
using CowApi.Models.Cows;

namespace CowApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CowsController : ControllerBase
    {
        private IMediator mediator;

        /// <summary>
        /// Gets the Mediator object.
        /// </summary>
        protected IMediator Mediator => mediator ??= (IMediator)HttpContext.RequestServices.GetService(typeof(IMediator))!;

        private readonly ILogger<CowsController> _logger;

        public CowsController(ILogger<CowsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the current cows
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Cow>> Get()
        {
            var reponse = await Mediator.Send(new GetCowsRequest());

            return reponse.Cows;
        }
    }
}
