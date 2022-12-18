using Contentful.Core;
using DevOpsContentful.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevOpsContentful.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Snippet> _snippet = new List<Snippet>();
        private readonly ILogger<HomeController> _logger;
        private readonly IContentfulClient _client;
       
        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult View1()
        {
            return View("View1");
        }
        //public IActionResult Snippets()
        //{
        //    return View("Snippets");
        //}
        public async Task<IActionResult> Snippets()
        {
            //var snippets = await _client.GetEntries<Snippet>();
            var snippets = await _client.GetAssets();
            
            return View(snippets);
            //return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
