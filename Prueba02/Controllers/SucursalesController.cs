using System;
using System.Web.Mvc;
using Prueba02.Entidades.Models;
using Prueba02.Negocio;

namespace Prueba02.Controllers
{
    public class SucursalesController : Controller
    {
        private readonly INegocio<Sucursal> _negocio;

        public SucursalesController()
        {
            _negocio = new SucursalesNegocio();
        }

        // GET: Sucursales
        public ActionResult Index()
        {
            var sucursales = _negocio.Listar();
            return View(sucursales);
        }

        // GET: Sucursales/Details/5
        public ActionResult Details(int id)
        {
            var model = _negocio.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }

        // GET: Sucursales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = ("Id, IdBanco, Nombre, Direccion, FechaRegistro"))]Sucursal sucursal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _negocio.Add(sucursal);

                    return RedirectToAction("Index");
                }

                return View(sucursal);
            }
            catch
            {
                return View(sucursal);
            }
        }

        // GET: Sucursales/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _negocio.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }

        // POST: Sucursales/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = ("Id, IdBanco, Nombre, Direccion, FechaRegistro"))]Sucursal model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _negocio.Update(model);

                    return RedirectToAction("Index");
                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursales/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _negocio.GetById(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }

        // POST: Sucursales/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _negocio.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}
