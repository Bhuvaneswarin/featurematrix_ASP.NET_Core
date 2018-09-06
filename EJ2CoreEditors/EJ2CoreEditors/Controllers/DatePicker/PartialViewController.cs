using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DatePicker
{
    public partial class DatePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PartialView()
        {
            ViewBag.Value = new DateTime(2017, 05, 07, 01, 00, 00);
            return PartialView("~/Views/DatePicker/PartialView.cshtml");
        }
    }
}
