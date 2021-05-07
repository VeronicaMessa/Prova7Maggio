using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7MaggioVeronicaMessa
{
    class Alloggio : ICategoria
    {
        public string Importo()
        {
            return "Il rimborso è 100% dell'importo";
        }
    }
}
