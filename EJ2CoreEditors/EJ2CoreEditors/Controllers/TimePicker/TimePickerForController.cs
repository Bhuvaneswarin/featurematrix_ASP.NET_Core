using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public class TimeValue
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }

    }
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult TimePickerFor()
        {
            TimeValue val = new TimeValue();
            val.value = DateTime.Now;
            return View(val);
        }
        [HttpPost]
        public IActionResult TimePickerFor(TimeValue model)
        {
            TimeValue val = new TimeValue();
            val.value = model.value;
            return View(val);
        }
    }
}
