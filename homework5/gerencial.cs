using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class gerencial
    {
        private static object cancelacion = new object();
        private static gerencial funcion;
        private gerencial() { }
        public string gerente = "Gerencial";
        public double suma = 0.50;
        public static gerencial Getfuncion
        {
            get
            {
                lock (cancelacion)
                {

                    if (funcion == null)
                    {
                        throw new Exception("Error");
                    }
                }
                return funcion;
            }
        }
        public static void Retencion()
        {
            lock (cancelacion)
            {
                if (funcion == null)
                {
                    funcion = new gerencial();
                    var rango = funcion.gerente;
                    var suma = funcion.suma;
                }
                else
                {
                    throw new Exception("NO SE LOGRO");
                }
            }
        }
    }
}
