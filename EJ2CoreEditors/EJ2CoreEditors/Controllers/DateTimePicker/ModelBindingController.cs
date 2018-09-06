using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateTimePicker
{
    public class DateTimePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult ModelBinding()
        {
            var model = new DateTimePickerModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View(model);
        }

        [HttpPost]
        public IActionResult ModelBinding(DateTimePickerModelBinding model)
        {
            return View(model);
        }
    }
}
