﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conectaconlamemoria.Controllers
{
    public class ArteyCulturaController : Controller
    {
        // GET: ArteyCultura
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArteyCultura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArteyCultura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArteyCultura/Create
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

        // GET: ArteyCultura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArteyCultura/Edit/5
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

        // GET: ArteyCultura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArteyCultura/Delete/5
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