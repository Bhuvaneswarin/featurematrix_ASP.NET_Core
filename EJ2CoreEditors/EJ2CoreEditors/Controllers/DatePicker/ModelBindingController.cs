using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DatePicker
{
    public class DatePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult ModelBinding()
        {
            var model = new DatePickerModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View();
        }
    }
}
