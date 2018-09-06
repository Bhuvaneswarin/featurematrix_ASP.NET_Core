using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DatePicker
{
    public partial class DatePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult TimeZone()
        {
            var isoDate = "2013-06-13T14:00:00.000Z";
            ViewBag.value1 = "2013-06-13T14:00:00.000";
            ViewBag.value2 = isoDate;
            return View();
        }
    }
}
