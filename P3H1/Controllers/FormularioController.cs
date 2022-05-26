using FormApplication.Service;
using FormApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace P3H1.Controllers
{
    public class FormularioController : Controller
    {
        private readonly SignoService signoService;
        public string Name { get; set; }

        public FormularioController()
        {
            signoService = new();
        }

        public IActionResult Index()
        {
            return View(signoService.GetAll());
        }

        public IActionResult Signo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signo(SignoCreateViewModel vm)
        {

            if(vm.Fecha == "2022-03-21" || vm.Fecha == "2022-03-22" || vm.Fecha == "2022-03-23" || vm.Fecha == "2022-03-24" || vm.Fecha == "2022-03-25" || vm.Fecha == "2022-04-26" || vm.Fecha == "2022-03-27" || vm.Fecha == "2022-03-28" || vm.Fecha == "2022-03-29" || vm.Fecha == "2022-03-30" || vm.Fecha == "2022-03-31" || vm.Fecha == "2022-04-01" || vm.Fecha == "2022-04-02" || vm.Fecha == "2022-04-03" ||  vm.Fecha == "2022-04-04" || vm.Fecha == "2022-04-05" || vm.Fecha == "2022-04-06" || vm.Fecha == "2022-04-07" || vm.Fecha == "2022-04-08" || vm.Fecha == "2022-04-09" || vm.Fecha == "2022-04-10" || vm.Fecha == "2022-04-11" || vm.Fecha == "2022-04-12" || vm.Fecha == "2022-04-13" || vm.Fecha == "2022-04-14" || vm.Fecha == "2022-04-15" || vm.Fecha == "2022-04-16" || vm.Fecha == "2022-04-17" || vm.Fecha == "2022-04-18" || vm.Fecha == "2022-04-19")
            {
                vm.Name = "Aries";
                signoService.Add(vm);
            }else if (vm.Fecha == "2022-04-20" || vm.Fecha == "2022-04-21" || vm.Fecha == "2022-04-22" || vm.Fecha == "2022-04-23" || vm.Fecha == "2022-04-24" || vm.Fecha == "2022-04-25" || vm.Fecha == "2022-04-26" || vm.Fecha == "2022-04-27" || vm.Fecha == "2022-04-28" || vm.Fecha == "2022-04-29" || vm.Fecha == "2022-04-30" || vm.Fecha == "2022-05-01" || vm.Fecha == "2022-05-02" || vm.Fecha == "2022-05-03" || vm.Fecha == "2022-05-04" || vm.Fecha == "2022-05-05" || vm.Fecha == "2022-05-06" || vm.Fecha == "2022-05-07" || vm.Fecha == "2022-05-08" || vm.Fecha == "2022-05-09" || vm.Fecha == "2022-05-10" || vm.Fecha == "2022-05-11" || vm.Fecha == "2022-05-12" || vm.Fecha == "2022-05-13" || vm.Fecha == "2022-05-14" || vm.Fecha == "2022-05-15" || vm.Fecha == "2022-05-16" || vm.Fecha == "2022-05-17" || vm.Fecha == "2022-05-18" || vm.Fecha == "2022-05-19" || vm.Fecha == "2022-05-20")
            {
                vm.Name = "Tauro";
                signoService.Add(vm);
            }else if (vm.Fecha == "2022-05-21" || vm.Fecha == "2022-05-22" || vm.Fecha == "2022-05-23" || vm.Fecha == "2022-05-24" || vm.Fecha == "2022-05-25" || vm.Fecha == "2022-05-26" || vm.Fecha == "2022-05-27" || vm.Fecha == "2022-05-28" || vm.Fecha == "2022-05-29" || vm.Fecha == "2022-05-30" || vm.Fecha == "2022-05-31" || vm.Fecha == "2022-06-01" || vm.Fecha == "2022-06-02" || vm.Fecha == "2022-06-03" || vm.Fecha == "2022-06-04" || vm.Fecha == "2022-06-05" || vm.Fecha == "2022-06-06" || vm.Fecha == "2022-06-07" || vm.Fecha == "2022-06-08" || vm.Fecha == "2022-06-09" || vm.Fecha == "2022-06-10" || vm.Fecha == "2022-06-11" || vm.Fecha == "2022-06-12" || vm.Fecha == "2022-06-13" || vm.Fecha == "2022-06-14" || vm.Fecha == "2022-06-15" || vm.Fecha == "2022-06-16" || vm.Fecha == "2022-06-17" || vm.Fecha == "2022-06-18" || vm.Fecha == "2022-06-19" || vm.Fecha == "2022-06-20")
            {
                vm.Name = "Géminis";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-06-21" || vm.Fecha == "2022-06-22" || vm.Fecha == "2022-06-23" || vm.Fecha == "2022-06-24" || vm.Fecha == "2022-06-25" || vm.Fecha == "2022-06-26" || vm.Fecha == "2022-06-27" || vm.Fecha == "2022-06-28" || vm.Fecha == "2022-06-29" || vm.Fecha == "2022-06-30" || vm.Fecha == "2022-07-01" || vm.Fecha == "2022-07-02" || vm.Fecha == "2022-07-03" || vm.Fecha == "2022-07-04" || vm.Fecha == "2022-07-05" || vm.Fecha == "2022-07-06" || vm.Fecha == "2022-07-07" || vm.Fecha == "2022-07-08" || vm.Fecha == "2022-07-09" || vm.Fecha == "2022-07-10" || vm.Fecha == "2022-07-11" || vm.Fecha == "2022-07-12" || vm.Fecha == "2022-07-13" || vm.Fecha == "2022-07-14" || vm.Fecha == "2022-07-15" || vm.Fecha == "2022-07-16" || vm.Fecha == "2022-07-17" || vm.Fecha == "2022-07-18" || vm.Fecha == "2022-07-19" || vm.Fecha == "2022-07-20" || vm.Fecha == "2022-07-21" || vm.Fecha == "2022-07-22")
            {
                vm.Name = "Cáncer";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-07-23" || vm.Fecha == "2022-07-24" || vm.Fecha == "2022-07-25" || vm.Fecha == "2022-07-26" || vm.Fecha == "2022-07-27" || vm.Fecha == "2022-07-28" || vm.Fecha == "2022-07-29" || vm.Fecha == "2022-07-30" || vm.Fecha == "2022-07-31" || vm.Fecha == "2022-08-01" || vm.Fecha == "2022-08-02" || vm.Fecha == "2022-08-03" || vm.Fecha == "2022-08-04" || vm.Fecha == "2022-08-05" || vm.Fecha == "2022-08-06" || vm.Fecha == "2022-08-07" || vm.Fecha == "2022-08-08" || vm.Fecha == "2022-08-09" || vm.Fecha == "2022-08-10" || vm.Fecha == "2022-08-11" || vm.Fecha == "2022-08-12" || vm.Fecha == "2022-08-13" || vm.Fecha == "2022-08-14" || vm.Fecha == "2022-08-15" || vm.Fecha == "2022-08-16" || vm.Fecha == "2022-08-17" || vm.Fecha == "2022-08-18" || vm.Fecha == "2022-08-19" || vm.Fecha == "2022-08-20" || vm.Fecha == "2022-08-21" || vm.Fecha == "2022-08-22" || vm.Fecha == "2022-08-23" )
            {
                vm.Name = "Leo";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-08-23" || vm.Fecha == "2022-08-24" || vm.Fecha == "2022-08-25" || vm.Fecha == "2022-08-26" || vm.Fecha == "2022-08-27" || vm.Fecha == "2022-08-28" || vm.Fecha == "2022-08-29" || vm.Fecha == "2022-08-30" || vm.Fecha == "2022-07-31" || vm.Fecha == "2022-09-01" || vm.Fecha == "2022-09-02" || vm.Fecha == "2022-09-03" || vm.Fecha == "2022-09-04" || vm.Fecha == "2022-09-05" || vm.Fecha == "2022-09-06" || vm.Fecha == "2022-09-07" || vm.Fecha == "2022-09-08" || vm.Fecha == "2022-09-09" || vm.Fecha == "2022-09-10" || vm.Fecha == "2022-09-11" || vm.Fecha == "2022-09-12" || vm.Fecha == "2022-09-13" || vm.Fecha == "2022-09-14" || vm.Fecha == "2022-09-15" || vm.Fecha == "2022-09-16" || vm.Fecha == "2022-09-17" || vm.Fecha == "2022-09-18" || vm.Fecha == "2022-09-19" || vm.Fecha == "2022-09-20" || vm.Fecha == "2022-09-21" || vm.Fecha == "2022-09-22" || vm.Fecha == "2022-09-23")
            {
                vm.Name = "Virgo";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-09-23" || vm.Fecha == "2022-09-24" || vm.Fecha == "2022-09-25" || vm.Fecha == "2022-09-26" || vm.Fecha == "2022-09-27" || vm.Fecha == "2022-09-28" || vm.Fecha == "2022-09-29" || vm.Fecha == "2022-09-30" || vm.Fecha == "2022-10-01" || vm.Fecha == "2022-10-02" || vm.Fecha == "2022-10-03" || vm.Fecha == "2022-10-04" || vm.Fecha == "2022-10-05" || vm.Fecha == "2022-10-06" || vm.Fecha == "2022-10-07" || vm.Fecha == "2022-10-08" || vm.Fecha == "2022-10-09" || vm.Fecha == "2022-10-10" || vm.Fecha == "2022-10-11" || vm.Fecha == "2022-10-12" || vm.Fecha == "2022-10-13" || vm.Fecha == "2022-10-14" || vm.Fecha == "2022-10-15" || vm.Fecha == "2022-10-16" || vm.Fecha == "2022-10-17" || vm.Fecha == "2022-10-18" || vm.Fecha == "2022-10-19" || vm.Fecha == "2022-10-20" || vm.Fecha == "2022-10-21" || vm.Fecha == "2022-10-22")
            {
                vm.Name = "Libra";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-10-23" || vm.Fecha == "2022-10-24" || vm.Fecha == "2022-10-25" || vm.Fecha == "2022-10-26" || vm.Fecha == "2022-10-27" || vm.Fecha == "2022-10-28" || vm.Fecha == "2022-10-29" || vm.Fecha == "2022-10-30" || vm.Fecha == "2022-10-31" || vm.Fecha == "2022-11-01" || vm.Fecha == "2022-11-02" || vm.Fecha == "2022-11-03" || vm.Fecha == "2022-11-04" || vm.Fecha == "2022-11-05" || vm.Fecha == "2022-11-06" || vm.Fecha == "2022-11-07" || vm.Fecha == "2022-11-08" || vm.Fecha == "2022-11-09" || vm.Fecha == "2022-11-10" || vm.Fecha == "2022-11-11" || vm.Fecha == "2022-11-12" || vm.Fecha == "2022-11-13" || vm.Fecha == "2022-11-14" || vm.Fecha == "2022-11-15" || vm.Fecha == "2022-11-16" || vm.Fecha == "2022-11-17" || vm.Fecha == "2022-11-18" || vm.Fecha == "2022-11-19" || vm.Fecha == "2022-11-20" || vm.Fecha == "2022-11-21")
            {
                vm.Name = "Escorpio";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-11-22" || vm.Fecha == "2022-11-23" || vm.Fecha == "2022-11-24" || vm.Fecha == "2022-11-25" || vm.Fecha == "2022-11-26" || vm.Fecha == "2022-11-27" || vm.Fecha == "2022-11-28" || vm.Fecha == "2022-11-29" || vm.Fecha == "2022-11-30" || vm.Fecha == "2022-12-01" || vm.Fecha == "2022-12-02" || vm.Fecha == "2022-12-03" || vm.Fecha == "2022-12-04" || vm.Fecha == "2022-12-05" || vm.Fecha == "2022-12-06" || vm.Fecha == "2022-12-07" || vm.Fecha == "2022-12-08" || vm.Fecha == "2022-12-09" || vm.Fecha == "2022-12-10" || vm.Fecha == "2022-12-11" || vm.Fecha == "2022-12-12" || vm.Fecha == "2022-12-13" || vm.Fecha == "2022-12-14" || vm.Fecha == "2022-12-15" || vm.Fecha == "2022-12-16" || vm.Fecha == "2022-12-17" || vm.Fecha == "2022-12-18" || vm.Fecha == "2022-12-19" || vm.Fecha == "2022-12-20" || vm.Fecha == "2022-12-21")
            {
                vm.Name = "Sagitorio";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-12-22" || vm.Fecha == "2022-12-23" || vm.Fecha == "2022-12-24" || vm.Fecha == "2022-12-25" || vm.Fecha == "2022-12-26" || vm.Fecha == "2022-12-27" || vm.Fecha == "2022-12-28" || vm.Fecha == "2022-12-29" || vm.Fecha == "2022-12-30" || vm.Fecha == "2022-12-31" || vm.Fecha == "2022-01-01" || vm.Fecha == "2022-01-02" || vm.Fecha == "2022-01-03" || vm.Fecha == "2022-01-04" || vm.Fecha == "2022-01-05" || vm.Fecha == "2022-01-06" || vm.Fecha == "2022-01-07" || vm.Fecha == "2022-01-08" || vm.Fecha == "2022-01-09" || vm.Fecha == "2022-01-10" || vm.Fecha == "2022-01-11" || vm.Fecha == "2022-01-12" || vm.Fecha == "2022-01-13" || vm.Fecha == "2022-01-14" || vm.Fecha == "2022-01-15" || vm.Fecha == "2022-01-16" || vm.Fecha == "2022-01-17" || vm.Fecha == "2022-01-18" || vm.Fecha == "2022-01-19")
            {
                vm.Name = "Capricornio";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-01-20" || vm.Fecha == "2022-01-21" || vm.Fecha == "2022-01-22" || vm.Fecha == "2022-01-23" || vm.Fecha == "2022-01-24" || vm.Fecha == "2022-01-25" || vm.Fecha == "2022-01-26" || vm.Fecha == "2022-01-27" || vm.Fecha == "2022-01-28" || vm.Fecha == "2022-01-29" || vm.Fecha == "2022-01-30" || vm.Fecha == "2022-01-31" || vm.Fecha == "2022-02-01" || vm.Fecha == "2022-02-02" || vm.Fecha == "2022-02-03" || vm.Fecha == "2022-02-04" || vm.Fecha == "2022-02-05" || vm.Fecha == "2022-02-06" || vm.Fecha == "2022-02-07" || vm.Fecha == "2022-02-08" || vm.Fecha == "2022-02-09" || vm.Fecha == "2022-02-10" || vm.Fecha == "2022-02-11" || vm.Fecha == "2022-02-12" || vm.Fecha == "2022-02-13" || vm.Fecha == "2022-02-14" || vm.Fecha == "2022-02-15" || vm.Fecha == "2022-02-16" || vm.Fecha == "2022-02-17" || vm.Fecha == "2022-02-18")
            {
                vm.Name = "Acuario";
                signoService.Add(vm);
            }
            else if (vm.Fecha == "2022-02-19" || vm.Fecha == "2022-02-20" || vm.Fecha == "2022-02-21" || vm.Fecha == "2022-02-22" || vm.Fecha == "2022-02-23" || vm.Fecha == "2022-02-24" || vm.Fecha == "2022-02-25" || vm.Fecha == "2022-02-26" || vm.Fecha == "2022-02-27" || vm.Fecha == "2022-02-28" || vm.Fecha == "2022-03-01" || vm.Fecha == "2022-03-02" || vm.Fecha == "2022-03-03" || vm.Fecha == "2022-03-04" || vm.Fecha == "2022-03-05" || vm.Fecha == "2022-03-06" || vm.Fecha == "2022-03-07" || vm.Fecha == "2022-03-08" || vm.Fecha == "2022-03-09" || vm.Fecha == "2022-03-10" || vm.Fecha == "2022-03-11" || vm.Fecha == "2022-03-12" || vm.Fecha == "2022-03-13" || vm.Fecha == "2022-03-14" || vm.Fecha == "2022-03-15" || vm.Fecha == "2023-03-16" || vm.Fecha == "2022-03-17" || vm.Fecha == "2022-03-18" || vm.Fecha == "2022-03-19" || vm.Fecha == "2022-03-20")
            {
                vm.Name = "Piscis";
                signoService.Add(vm);
            }

            return RedirectToRoute(new { controller = "Formulario", action = "Index" });
        }
    }
}
