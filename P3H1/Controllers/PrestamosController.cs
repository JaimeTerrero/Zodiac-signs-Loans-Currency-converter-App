using LoansApplication.Service;
using LoansApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace P3H1.Controllers
{
    public class PrestamosController : Controller
    {
        private readonly PrestamoService prestamoService;
        public double Personal = 0.22;
        public double Automovil = 0.12;
        public double Hipotecario = 0.08;
        public double valor;
        public double MontoPrestamo;

        public PrestamosController()
        {
            prestamoService = new ();
        }

        public IActionResult Index()
        {
            return View(prestamoService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PrestamosCreateViewModel vm)
        {

            if(vm.TipoPrestamo == 1 && vm.CuotasMensuales == 1)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 12;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if(vm.TipoPrestamo == 1 && vm.CuotasMensuales == 2)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 18;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 3)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 24;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 4)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 30;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 5)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 36;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 6)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 42;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 7)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 48;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 8)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 54;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 9)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 60;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 10)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 66;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 11)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 72;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 12)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 78;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 13)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 84;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 14)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 90;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 15)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 96;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 16)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 102;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 17)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 108;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 18)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 114;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 1 && vm.CuotasMensuales == 19)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Personal;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 120;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 1)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 12;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 2)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 18;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 3)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 24;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 4)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 30;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 5)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 36;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 6)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 42;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 7)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 48;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 8)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 54;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 9)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 60;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 10)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 66;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 11)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 72;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 12)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 78;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 13)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 84;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 14)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 90;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 15)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 96;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 16)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 102;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 17)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 108;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 18)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 114;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 2 && vm.CuotasMensuales == 19)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Automovil;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 120;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 1)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 12;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 2)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 18;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 3)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 24;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 4)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 30;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 5)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 36;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 6)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 42;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 7)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 48;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 8)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 54;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 9)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 60;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 10)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 66;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 11)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 72;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 12)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 78;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 13)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 84;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 14)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 90;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 15)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 96;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 16)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 102;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 17)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 108;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 18)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 114;

                vm.CuotaMensual = Math.Round(valor, 2);
            }
            else if (vm.TipoPrestamo == 3 && vm.CuotasMensuales == 19)
            {
                MontoPrestamo = vm.MontoPrestamo;
                vm.MontoPrestamo *= Hipotecario;
                valor = (vm.MontoPrestamo + MontoPrestamo) / 120;

                vm.CuotaMensual = Math.Round(valor, 2);
            }

            prestamoService.Add(vm);
            return RedirectToRoute(new { controller = "Prestamos", action = "Index" });
        }
    }
}
