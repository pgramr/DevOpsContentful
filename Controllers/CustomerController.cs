using Contentful.Core;
using Contentful.Core.Models;
using DevOpsContentful.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DevOpsContentful.Controllers
{
    public class CustomerController : Controller
    {
        IEnumerable<Customer> _customersEnum = new List<Customer>();
        private readonly IContentfulClient _client;
        private readonly HttpClient httpClient1 = new HttpClient();
     
        public CustomerController(IContentfulClient client)
        {
            _client = client;
        }
        // GET: CustomerController
        public async Task<ActionResult> View1()
        {
            var customers = await _client.GetEntries<Customer>();
            _customersEnum = customers;
            return View(_customersEnum);
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("View2");
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(View1));
            }
            catch
            {
                return View("View2");
            }
        }

    }
}
