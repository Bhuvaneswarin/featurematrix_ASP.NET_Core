using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DateTimePicker
{
    public class DateTimeValue
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }

    }
    public partial class DateTimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult DateTimePickerFor()
        {
            DateTimeValue val = new DateTimeValue();
            val.value = DateTime.Now;
            return View(val);
        }
        [HttpPost]
        public IActionResult DateTimePickerFor(DateTimeValue model)
        {
            DateTimeValue val = new DateTimeValue();
            val.value = model.value;
            return View(val);
        }
    }
}
