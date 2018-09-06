using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Globalization()
        {
            ViewBag.minVal = new DateTime(2017, 08, 03, 09, 00, 00);
            ViewBag.maxVal = new DateTime(2017, 08, 03, 11, 30, 00);
            ViewBag.value = new DateTime(2017, 08, 03, 11, 00, 00);
            return View();
        }
    }
}
