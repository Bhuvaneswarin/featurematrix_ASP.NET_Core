using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateTimePicker
{
    public partial class DateTimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 7, 0, 0, 0);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return View();
        }
    }
}
