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
        public IActionResult TimeZone()
        {
            ViewBag.startDate1 = "2013-06-13T14:00:00.000";
            ViewBag.endDate1 = "2013-06-13T15:30:00.000";

            ViewBag.startDate2 = "2013-06-13T14:00:00.000Z";
            ViewBag.endDate2 = "2013-06-13T15:30:00.000Z";
            return View();
        }
    }
}
