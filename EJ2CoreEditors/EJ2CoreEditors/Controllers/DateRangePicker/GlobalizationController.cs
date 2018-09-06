using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 15);
            return View();
        }
    }
}
