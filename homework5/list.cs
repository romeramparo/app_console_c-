using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class list
    {
        private static List<datos> empleados = new List<datos>();

        public static List<datos> Bono()
        {
            return empleados;
        }
        public void agregarempleado(datos list)
        {
            if (list != null)
            {
                empleados.Add(list);
            }
        }
        public string mostrarlista()
        {
            string mess = "Lista Empleados \n";
            int min = 1001;
            int max = 9999;
            int code = 1;
            Random rnd = new Random();
            foreach (datos list in empleados)
            {
                mess += "Code: " + code++ + "\n";
                mess += "Cedula: " + list.cedulaempleados + "\n";
                mess += "Codigo empleado: " + list.codigoempleado + "#" + rnd.Next(min, max + 1) + "\n";
                mess += "Nombre: " + list.nombresempleados + "\n";
                mess += "Apellido: " + list.apellidosempleados + "\n";
                mess += "Email: " + list.emailempleados + "\n";
                mess += "Telefono: " + list.telefonoempleados + "\n";
                mess += "Departamento: " + list.departamentoempleados + "\n";
                mess += "Cargo: " + list.cargoempleados + "\n";
                //mess += "Salario: " + list.salarioempleado + "\n";
                mess += "***********************************" + "\n";
            }
            return mess;
        }
    }
}
