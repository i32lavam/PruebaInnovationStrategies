using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaInnovationStrategies.Controllers
{
    public class FicheroController : Controller
    {

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View();
        }

        // GET: Fichero
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Fichero/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Fichero/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Fichero/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Fichero/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Fichero/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Fichero/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Fichero/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
