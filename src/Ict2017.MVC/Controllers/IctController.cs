using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ict2017.MVC.Models;
using Ict2017.Common;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Ict2017.MVC.Controllers
{
    public class IctController : Controller
    {
        private readonly IIctService service;

        public IctController(IIctService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Clap([FromForm] int id)
        {
            await service.IncrementClapCountAsync(id);
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Append($"clap-{id}", "clapped", options);
            return RedirectToAction(nameof(Presentations));
        }

        public async Task<IActionResult> Presentations()
        {
            var presentations = await service.GetPresentationsAsync();
            return View(presentations);
        }

        public async Task<IActionResult> Gallery([Range(1, 15)]int page)
        {
            var galleryItem = await service.GetGalleryItemAsync(page);
            return View(galleryItem);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
