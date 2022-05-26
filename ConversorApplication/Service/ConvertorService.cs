using ConversorApplication.Repository;
using ConversorApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorApplication.Service
{
    public class ConvertorService
    {
        public void Add(ConvertorCreateViewModel vm)
        {
            ConvertorRepository.Instance.Convertor.Conversiones.Add(new ConvertorViewModel { Name = vm.Name, Result = vm.Amount }); 
        }

        public ConvertorListViewModel GetAll()
        {
            return ConvertorRepository.Instance.Convertor;
        }
    }
}
