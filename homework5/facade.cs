using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class facade
    {
        datos d = new datos();
        list obj = new();
        contexto contexto = null;

        public facade(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("\nCREANDO EMPLEADOS: ");
                Console.WriteLine("Ingrese cedula: ");
                var inputcedulaempleado = Console.ReadLine();
                Console.WriteLine("Ingrese nombre: ");
                var inputnombreempleado = Console.ReadLine();
                Console.WriteLine("Ingrese apellido: ");
                var inputapellidoempleado = Console.ReadLine();
                Console.WriteLine("Ingrese email: ");
                var inputemailempleado = Console.ReadLine();
                Console.WriteLine("Ingrese telefono: ");
                var inputtelefonoempleado = Console.ReadLine();
                Console.WriteLine("Ingrese departamento: ");
                var inputdepartamentoempleado = Console.ReadLine();
                Console.WriteLine("Ingrese cargo: ");
                var inputcargoempleado = Console.ReadLine();
                if (inputcargoempleado == "gerencial" || inputcargoempleado == "Gerencial")
                {
                    try
                    {
                        gerencial.Retencion();
                        gerencial ger = gerencial.Getfuncion;
                        inputcargoempleado = ger.gerente;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("NO PUEDE CREAR DOS EMPLEADOS CON EL CARGO GERENTE COMPANERO");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                string codigoempleado = inputdepartamentoempleado.Substring(0, 4);
                if (inputcedulaempleado != null && inputapellidoempleado != null && inputcedulaempleado != null && codigoempleado != null && inputnombreempleado != null && inputemailempleado != null && inputdepartamentoempleado != null && inputcargoempleado != null)
                {
                    obj.agregarempleado(new datos(
                        long.Parse(inputcedulaempleado),
                        codigoempleado,
                        inputapellidoempleado.ToString(),
                        inputnombreempleado.ToString(),
                        inputemailempleado.ToString(),
                        inputdepartamentoempleado.ToString(),
                        inputtelefonoempleado.ToString(),
                        inputcargoempleado.ToString()
                        ));
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("EN QUE FORMATO DESEA GUARDAR AL EMPLEADO");
                Console.WriteLine("[c] = CVC");
                Console.WriteLine("[j] = JSON");
                Console.WriteLine("[t] = TXT");
                string op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "c":
                        csv excel = new csv();
                        contexto = new contexto(excel);
                        break;
                    case "j":
                        json json = new json();
                        contexto = new contexto(json);
                        break;
                    case "t":
                        txt nota = new txt();
                        contexto = new contexto(nota);
                        break;
                    default:
                        Console.WriteLine("OPCION FUERA DEL RANGO NECESARIO");
                        break;
                }contexto.run(op);
            }
            else if (option == 3)
            {
                Console.WriteLine("\nVISUALIZANDO EMPLEADOS");
                Console.WriteLine(obj.mostrarlista());
                Console.ReadKey();
            }
            else if (option == 4)
            {
                Environment.Exit(0);
            }
        }
    }
}
