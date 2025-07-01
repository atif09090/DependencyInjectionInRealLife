using DependencyInjectionInRealLife.Application;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionInRealLife.Controllers
{
    /// <summary>
    /// Handles job application submissions via different service implementations.
    /// Demonstrates tightly-coupled and loosely-coupled service approaches.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly JobApplicationService _tightlyCoupledService;
        private readonly EfficientJobApplicationService _looselyCoupledService;

        /// <summary>
        /// Constructor for injecting job application services.
        /// </summary>
        /// <param name="tightlyCoupledService">Service with tightly coupled dependencies.</param>
        /// <param name="looselyCoupledService">Service with loosely coupled dependencies via DI.</param>
        public ApplicationController(
            JobApplicationService tightlyCoupledService,
            EfficientJobApplicationService looselyCoupledService)
        {
            _tightlyCoupledService = tightlyCoupledService;
            _looselyCoupledService = looselyCoupledService;
        }

        /// <summary>
        /// Submits a job application using a tightly-coupled implementation.
        /// </summary>
        /// <param name="name">Applicant name.</param>
        [HttpPost("tight-coupled")]
        public IActionResult ApplyWithTightlyCoupledService([FromQuery] string name)
        {
            _tightlyCoupledService.Apply(name);
            return Ok("Job application processed using tightly coupled service.");
        }

        /// <summary>
        /// Submits a job application using a loosely-coupled (DI) implementation.
        /// </summary>
        /// <param name="name">Applicant name.</param>
        [HttpPost("loose-coupled")]
        public IActionResult ApplyWithLooselyCoupledService([FromQuery] string name)
        {
            _looselyCoupledService.Apply(name);
            return Ok("Job application processed using loosely coupled service.");
        }
    }
}
