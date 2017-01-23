using System;
using System.Diagnostics;
using System.Web.Mvc;
using Prueba02.Entidades.Models;
using Prueba02.Negocio;

namespace Prueba02.Controllers
{
    public class BancosController : Controller
    {
        private readonly INegocio<Banco> _negocio;

        public BancosController()
        {
            _negocio = new BancosNegocio();
        }

        // GET: Bancos
        public ActionResult Index()
        {
            var bancos = _negocio.Listar();
            return View(bancos);
        }

        // GET: Bancos/Details/5
        public ActionResult Details(int id)
        {
            var banco = _negocio.GetById(id);
            if (banco == null)
                return HttpNotFound();
            return View(banco);
        }

        // GET: Bancos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bancos/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Nombre,Direccion,FechaRegistro")] Banco banco)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _negocio.Add(banco);

                    return RedirectToAction("Index");
                }

                return View(banco);
            }
            catch
            {
                return View(banco);
            }
        }

        // GET: Bancos/Edit/5
        public ActionResult Edit(int id)
        {
            var banco = _negocio.GetById(id);
            if (banco == null)
                return HttpNotFound();
            return View(banco);
        }

        // POST: Bancos/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Direccion,FechaRegistro")] Banco banco)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _negocio.Update(banco);

                    return RedirectToAction("Index");
                }
                return View(banco);
            }
            catch
            {
                return View();
            }
        }

        // GET: Bancos/Delete/5
        public ActionResult Delete(int id)
        {
            var banco = _negocio.GetById(id);
            if (banco == null)
                return HttpNotFound();
            return View(banco);
        }

        // POST: Bancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _negocio.Delete(id);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return View();
            }
        }
    }
}
