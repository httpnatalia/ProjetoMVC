using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMVC.Views
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
