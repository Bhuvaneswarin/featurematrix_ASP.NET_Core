using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.DatePicker
{
    public class DatePickerPostBack
    {
        [Required(ErrorMessage = "Please enter the value")]
        public DateTime? value { get; set; }

    }
    public partial class DatePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PostBack()
        {
            DatePickerPostBack val = new DatePickerPostBack();
            val.value = DateTime.Now;
            return View(val);
        }
        [HttpPost]
        public IActionResult PostBack(DatePickerPostBack model)
        {
            DatePickerPostBack val = new DatePickerPostBack();
            val.value = model.value;
            return View(val);
        }
    }
}
