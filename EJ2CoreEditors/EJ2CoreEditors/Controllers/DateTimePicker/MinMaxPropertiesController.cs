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
        public IActionResult MinMaxProperties()
        {
            ViewBag.minDate = new DateTime(2019, 11, 22, 12, 00, 00);
            ViewBag.maxDate = new DateTime(2019, 11, 25, 05, 00, 00);
            return View();
        }
    }
}
