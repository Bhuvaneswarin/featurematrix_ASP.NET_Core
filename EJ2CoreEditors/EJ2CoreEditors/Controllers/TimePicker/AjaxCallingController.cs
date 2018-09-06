using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public class TimePickerAjaxValue
    {
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult AjaxCalling()
        {
            var model = new TimePickerAjaxValue();
            model.value = new DateTime(2017, 08, 03, 11, 00, 00);
            return View(model);
        }
        [HttpPost]
        public IActionResult AjaxCalling(TimePickerAjaxValue model)
        {
            return View(model);
        }
    }
}
