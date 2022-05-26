using LoansApplication.Repository;
using LoansApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansApplication.Service
{
    public class PrestamoService
    {
        public void Add(PrestamosCreateViewModel vm)
        {
            PrestamosRepository.Instance.Convertor.Prestamos.Add(new PrestamosViewModel { Resultado = vm.CuotaMensual });
        }

        public PrestamosListViewModel GetAll()
        {
            return PrestamosRepository.Instance.Convertor;
        }
    }
}
