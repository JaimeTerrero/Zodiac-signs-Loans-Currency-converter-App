using ConversorApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorApplication.Repository
{
    public sealed class ConvertorRepository
    {
        public static ConvertorRepository Instance { get; set; } = new ();
        public ConvertorListViewModel Convertor = new();

        private ConvertorRepository()
        {

        }
    }
}
