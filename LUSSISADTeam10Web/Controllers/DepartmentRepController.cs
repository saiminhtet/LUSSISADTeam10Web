﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LUSSISADTeam10Web.Controllers
{
    public class DepartmentRepController : Controller
    {
        // GET: DepartmentRep
        public ActionResult Index()
        {
            return View("DeptRepDashboard");
        }
    }
}