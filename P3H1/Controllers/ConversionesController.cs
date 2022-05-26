using ConversorApplication.Service;
using ConversorApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace P3H1.Controllers
{
    public class ConversionesController : Controller
    {
        private readonly ConvertorService convertorService;
        public double dolar;
        public double euro;
        public double peso;

        public ConversionesController()
        {
            convertorService = new ();
        }
        public IActionResult Inicio()
        {
            return View(convertorService.GetAll());
        }

        public IActionResult Conversion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Conversion(ConvertorCreateViewModel vm)
        {
            if (vm.ConvertorType == 1 && vm.ConvertorType2 == 1)
            {
                vm.Name = "DOP";
            }
            else if(vm.ConvertorType == 1 && vm.ConvertorType2 == 2)
            {
                vm.Amount /= 55.20;
                dolar = vm.Amount;
                vm.Amount = Math.Round(dolar, 2);
                vm.Name = "USD";
            }else if(vm.ConvertorType == 1 && vm.ConvertorType2 == 3)
            {
                vm.Amount /= 58.95;
                euro = vm.Amount;
                vm.Amount = Math.Round(euro, 2);
                vm.Name = "EUR";
            }
            else if (vm.ConvertorType == 2 && vm.ConvertorType2 == 1)
            {
                vm.Amount *= 55.20;
                peso = vm.Amount;
                vm.Amount = Math.Round(peso, 2);
                vm.Name = "DOP";
            }
            else if (vm.ConvertorType == 2 && vm.ConvertorType2 == 2)
            {
                vm.Name = "USD";
            }
            else if (vm.ConvertorType == 2 && vm.ConvertorType2 == 3)
            {
                vm.Amount *= 0.93;
                euro = vm.Amount;
                vm.Amount = Math.Round(euro, 2);
                vm.Name = "EUR";
            }
            else if (vm.ConvertorType == 3 && vm.ConvertorType2 == 1)
            {
                vm.Amount *= 58.95;
                peso = vm.Amount;
                vm.Amount = Math.Round(peso, 2);
                vm.Name = "DOP";
            }
            else if (vm.ConvertorType == 3 && vm.ConvertorType2 == 2)
            {
                vm.Amount *= 1.07;
                dolar = vm.Amount;
                vm.Amount = Math.Round(dolar, 2);
                vm.Name = "USD";
            }
            else if (vm.ConvertorType == 3 && vm.ConvertorType2 == 3)
            {
                vm.Name = "EUR";
            }

            convertorService.Add(vm);
            return RedirectToRoute(new { controller = "Conversiones", action = "Inicio" });
        }
    }
}
