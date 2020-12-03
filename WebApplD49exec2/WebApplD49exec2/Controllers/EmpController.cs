using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplD49exec2.Models;

namespace WebApplD49exec2.Controllers
{
    public class EmpController : Controller
    {
     

        public IActionResult Index()
        {
            List<Emp> emplist = new List<Emp>
            { new Emp{ EId = 1, EName = "rahul", EDesig = "devloper", EDoj = "10/10/2010" },
            new Emp{ EId = 2, EName = "rohit", EDesig = "manager", EDoj = "11/10/2010" },
            new Emp{ EId = 3, EName = "rajan", EDesig = "devloper", EDoj = "12/10/2010" },

            };
            return View(emplist);
        }
    }
}
