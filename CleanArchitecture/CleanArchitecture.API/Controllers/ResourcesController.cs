using CleanArchitecture.API.Models;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly IResourcesCreatable resourceCreator;
        private readonly ILogger logger;

        public ResourcesController(IResourcesCreatable resourceCreator, ILogger<ResourcesController> logger)
        {
            this.resourceCreator = resourceCreator;
            this.logger = logger;

        }
        
        [HttpGet]
        public List<ResourceDto> Get()
        {
            return new List<ResourceDto>();
        }

        [HttpGet]
        public ActionResult<ResourceDto> GetById(Guid id)
        {
            return Ok(new ResourceDto());
        }

        [HttpPost]
        public IActionResult Post(CreateResurceRequest resource)
        {
            this.logger.LogInformation($"Received new create resource rewuest:{resource.Name}");
            this.resourceCreator.CreateResources(new List<Resource>() { new() });
            return Ok();
        }

        [HttpPost]
        public IActionResult Put(CreateResurceRequest resource)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }

    }
}
