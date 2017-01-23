using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba02.Controllers
{
    public class OrdenPagosController : Controller
    {
        // GET: OrdenPagos
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrdenPagos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdenPagos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdenPagos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdenPagos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdenPagos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdenPagos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdenPagos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
