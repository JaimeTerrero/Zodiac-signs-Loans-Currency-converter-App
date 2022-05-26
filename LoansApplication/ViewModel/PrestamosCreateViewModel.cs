using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansApplication.ViewModel
{
    public class PrestamosCreateViewModel
    {
        public double MontoPrestamo { get; set; }
        public int TipoPrestamo { get; set; }
        public int CuotasMensuales { get; set; }
        public double TasaInteresAnual { get; set; }
        public double CuotaMensual { get; set; }
    }
}
