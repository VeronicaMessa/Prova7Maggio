using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7MaggioVeronicaMessa.Handlers
{
     interface IFileSerializable
    {
         void SaveToFile(string fileName);
         void LoadFromFile(string fileName);
    }
}
