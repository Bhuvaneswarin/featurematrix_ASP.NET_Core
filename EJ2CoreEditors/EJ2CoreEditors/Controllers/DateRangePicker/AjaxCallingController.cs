using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public class DateRangePickerAjax
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult AjaxCalling()
        {
            var model = new DateRangePickerAjax();
            model.startDate = new DateTime(2017, 11, 09);
            model.endDate = new DateTime(2017, 11, 21);
            return View(model);
        }

        [HttpPost]
        public IActionResult AjaxCalling(DateRangePickerAjax model)
        {
            return View(model);
        }
    }
}
