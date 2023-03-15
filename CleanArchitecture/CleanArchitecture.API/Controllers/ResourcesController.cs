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

        public ResourcesController(IResourcesCreatable resourceCreator)
        {
            this.resourceCreator = resourceCreator;
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
            this.resourceCreator.CreateResources(new List<Resource>() { new() };
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
