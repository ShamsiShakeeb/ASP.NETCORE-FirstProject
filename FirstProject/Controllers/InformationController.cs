using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            var info1 = new InformationViewModel();
            var info2 = new InformationViewModel();

            info1.Id = 1;
            info1.Email = "jakas1gy@gmail.com";
            info1.Name = "Abir";

            info2.Id = 2;
            info2.Email = "jakas1gyz@gmail.com";
            info2.Name = "LOL";

            List<InformationViewModel> listInfo = new List<InformationViewModel>();
            listInfo.Add(info1);
            listInfo.Add(info2);
            return View(listInfo);
        }
    }
}
