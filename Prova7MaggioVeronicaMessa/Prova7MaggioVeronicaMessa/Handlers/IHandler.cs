using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7MaggioVeronicaMessa.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //metodo che prende in carico la richiesta 
        string Handle(string request); //metodo che gestisce la richiesta 

    }
}
