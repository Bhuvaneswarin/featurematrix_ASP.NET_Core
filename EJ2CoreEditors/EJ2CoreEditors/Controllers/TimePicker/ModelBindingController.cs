using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public class TimePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult ModelBinding()
        {
            var model = new TimePickerModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View(model);
        }

        [HttpPost]
        public IActionResult ModelBinding(TimePickerModelBinding model)
        {
            return View(model);
        }
    }
}
