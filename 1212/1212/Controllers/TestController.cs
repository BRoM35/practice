using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1212.Controllers
{
    public class TestController : Controller
    {
        [Route("api/[controller]")]
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet("{id}")]
        public string Get(int id, [FromQuery]string foo, [FromQuery]string bar)
        {
            return id  +"" + foo + "" + bar;
        }

        //public ActionResult<int> Get(int id)
        //{
        //    return id;
        //}
        // GET: Test/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Test/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Test/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Test/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Test/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Test/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Test/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}