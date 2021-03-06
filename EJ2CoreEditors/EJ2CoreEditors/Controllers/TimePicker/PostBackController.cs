﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreEditors.Controllers.TimePicker
{
    public class TimePickerPostBack
    {
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: /<controller>/
        public IActionResult PostBack()
        {
            var model = new TimePickerPostBack();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public IActionResult PostBack(TimePickerPostBack model)
        {
            return View(model);
        }
    }
}
