using RobanEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobanEnergy.Controllers
{
    public class UserDetailController : Controller
    {
        // GET: UserDetail
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserDetail/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDetail/Create
        public ActionResult Create()
        {
            return View();
        }





        // POST: UserDetail/Create
        [HttpPost]
        public ActionResult Create(UserDetail us )
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserDetail/Edit/5
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

        // GET: UserDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDetail/Delete/5
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
