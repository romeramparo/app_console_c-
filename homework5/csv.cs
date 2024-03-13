using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class csv : Istrategy
    {
        public void SalvarEmpleado(string data)
        {
            list obj = new();
            Console.WriteLine("GUARDADO EN UN DOCUMENTO DE TIPO CSV");
            TextWriter textWriter;
            textWriter = new StreamWriter("Data.csv");
            string info;
            info = obj.mostrarlista();
            textWriter.WriteLine(info);
            textWriter.Close();
            Console.WriteLine("ARCHIVO GUARDADO CORRECTAMENTE EN UN CSV");
            Console.ReadKey();
        }
    }
}
