﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ru.GameSchool.Web.Controllers
{
    public class LevelController : BaseController
    {
        //
        // GET: /Level/

        public ActionResult Get(int id)
        {
            return View();
        }

        public ActionResult Create(int id)
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        /*
        public ActionResult Statistics(int id)
        {
            return View();
        }*/

    }
}
