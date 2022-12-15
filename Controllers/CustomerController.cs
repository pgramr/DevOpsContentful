using Contentful.Core;
using DevOpsContentful.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ContentfulManagementClient GetClient()
        {
            var client = new ContentfulManagementClient(httpClient1, "CFPAT-jKh-8Ow0RWjRyEK39dgunPtCKPG8wa-0cPZfoho9IQw", "qui5qc0w6jjg");
            return client;
        }
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
            //return View();
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }
    }
}
