using LugaresTuristicos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LugaresTuristicos.DB;

namespace LugaresTuristicos.Controllers
{
    public class PrincipalController : Controller
    {
        DBEntradasEntities2 context = new DBEntradasEntities2();
        public ActionResult Index()
        {
            var lugares = context.LugarTuristicos.ToList();
            return View("Index", lugares);
        }
    }
}