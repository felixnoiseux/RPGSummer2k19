using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebGestion.Controllers
{
    public class ResetController : Controller
    {
        // GET: Reset
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reset/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reset/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reset/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reset/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Reset/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reset/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}