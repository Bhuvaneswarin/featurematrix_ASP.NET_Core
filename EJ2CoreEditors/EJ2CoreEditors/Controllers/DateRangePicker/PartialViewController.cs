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
        public IActionResult PartialView()
        {
            ViewBag.startDate = new DateTime(2017, 11, 09);
            ViewBag.endDate = new DateTime(2017, 11, 21);
            return PartialView("~/Views/DateRangePicker/PartialView.cshtml");
        }
    }
}
