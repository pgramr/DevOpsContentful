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
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View("Details");
        }
       
         //GET: CustomerController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            var iclient = GetClient();
            //try
            //{
                
                var entry = new Entry<dynamic>();
                entry.SystemProperties = new SystemProperties();
                entry.SystemProperties.Version = 1;
            entry.SystemProperties.Id = "Customer";
            entry.Fields.Name = new Dictionary<string, string>() { { "en-US", "Jan" } };
            entry.Fields.Address = new Dictionary<string, string>() { { "en-US", "Jan" } };
            entry.Fields.IBAN = new Dictionary<string, string>() { { "en-US", "Jan" } };
            entry.Fields.VTA = new Dictionary<string, string>() { { "en-US", "Jan" } };


            return (IActionResult)await iclient.CreateEntry<dynamic>(entry, contentTypeId: "Customer");
                
            //return RedirectToAction(nameof(Create));
            
            //catch
            //{
            //    return View();
            //}
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
        //public async Task<ActionResult> Delete(int id)
        //{

        //    var client0 = new ContentfulManagementClient(httpClient1, "CFPAT-jKh-8Ow0RWjRyEK39dgunPtCKPG8wa-0cPZfoho9IQw", "qui5qc0w6jjg");
        //    await client0.DeleteEntry()

        //    return View();
        //} 

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
