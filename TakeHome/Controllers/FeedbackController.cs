﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;

namespace TakeHome.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }

        // POST: Feedback
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Feedback(FeedbackForm form)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", form);
            }
            else
                ViewBag.Result = "Invalid Entries, Kindly Recheck.";
            return View();
        }

    }
}