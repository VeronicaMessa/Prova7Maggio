using System;
using System.IO;

namespace Prova7MaggioVeronicaMessa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handlers.IFileSerializable spese = new Handlers.SpeseHandler();
            //spese.LoadFromFile("spese.txt");
            ISpese spese = new GestioneSpese();
            spese.LoadFromFile("spese.txt");
            //foreach (string line in spese)
            //{
            //    // Use a tab to indent each line of the file.
            //    Console.WriteLine("\t" + line);
            //}
           
        }
    }
}
