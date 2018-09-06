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
        public IActionResult TimeZone()
        {
            var isoDate = "2018-09-05T10:35:15.282Z";
            ViewBag.value1 = "2018-09-05T10:35:15.282";
            ViewBag.value2 = isoDate;
            return View();
        }
    }
}
