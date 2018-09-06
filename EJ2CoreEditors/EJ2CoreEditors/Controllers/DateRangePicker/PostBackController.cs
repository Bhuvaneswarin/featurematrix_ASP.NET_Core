using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateRangePicker
{
    public class DateRangePostBack
    {
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PostBack()
        {
            var model = new DateRangePostBack();
            model.startDate = new DateTime(2017, 11, 09);
            model.endDate = new DateTime(2017, 11, 21);
            return View(model);
        }
        [HttpPost]
        public IActionResult PostBack(DateRangePostBack model)
        {
            return View(model);
        }
    }
}
