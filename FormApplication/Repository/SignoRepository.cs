using FormApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApplication.Repository
{
    // Singleton
    public sealed class SignoRepository
    {
        public static SignoRepository Instance { get; } = new ();
        public SignoListViewModel Signos = new();

        private SignoRepository()
        {

        }
    }
}
