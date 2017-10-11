using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Ict2017.Common;
using Ict2017.Common.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ict2017.WebApi.Controllers
{
    [Route("api")]
    public class IctController : Controller
    {
        private readonly IIctService service;

        public IctController(IIctService service)
        {
            this.service = service;
        }

        [HttpPost("presentations")]
        public async Task<IActionResult> Clap([FromBody] ViewModelBase vm)
        {
            await service.IncrementClapCountAsync(vm.Id);
            return NoContent();
        }

        [HttpGet("presentations")]
        public async Task<IActionResult> Presentations()
        {
            var presentations = await service.GetPresentationsAsync();
            return Ok(presentations);
        }

        [HttpGet("gallery/{page:range(1,15)}")]
        public async Task<IActionResult> Gallery(int page)
        {
            var galleryItem = await service.GetGalleryItemAsync(page);
            return Ok(galleryItem);
        }

    }
}
