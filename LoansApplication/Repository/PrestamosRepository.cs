using LoansApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansApplication.Repository
{
    public sealed class PrestamosRepository
    {
        public static PrestamosRepository Instance { get; set; } = new();
        public PrestamosListViewModel Convertor = new();

        private PrestamosRepository()
        {

        }
    }
}
