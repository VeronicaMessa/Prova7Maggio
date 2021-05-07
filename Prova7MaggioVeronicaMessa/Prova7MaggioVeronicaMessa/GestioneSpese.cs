using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova7MaggioVeronicaMessa
{
    class GestioneSpese : ISpese
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public int Importo { get; set; }


        public void LoadFromFile(string fileName)
        {
            try
            {
                using StreamReader reader = File.OpenText($"C:\\Users\\veronica.messa\\Desktop\\Corso\\Prova7MaggioVeronicaMessa\\{fileName}");
                //Values:My Circle;12;10;4.5
                //string instanceData = reader.ReadLine().Split(":")[1];// prendi tutti i dati dopo i due punti 
                string instanceData = reader.ReadLine();

                string[] values = instanceData.Split(";");
               Data = DateTime.Parse(values[0]);
                Categoria = values[1];
                Descrizione = values[2];
                int.TryParse(values[3], out int importo);
                Importo = importo;
                reader.Close();
               
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }


        public void SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
