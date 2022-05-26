using FormApplication.Repository;
using FormApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Service
{
    public class SignoService
    {
        

        public void Add(SignoCreateViewModel vm)
        {
            SignoRepository.Instance.Signos.SignoList.Add(new FormViewModel { Name = vm.Name, Fecha = vm.Fecha });
        }

        public SignoListViewModel GetAll()
        {
            return SignoRepository.Instance.Signos;
        }
    }
}
