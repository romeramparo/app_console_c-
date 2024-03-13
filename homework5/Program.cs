namespace homework5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            facade facade = null;
            do
            {
                Console.Clear();
                Console.WriteLine("*-*-*-*MENU DE OPCIONES*-*-*-*");
                Console.WriteLine("Seleccione la operacion que desea realizar");
                Console.WriteLine("[1] INGRESAR EMPLEADO");
                Console.WriteLine("[2] SALVAR REGISTRO EMPLEADO");
                Console.WriteLine("[3] MOSTRAR EMPLEADOS");
                Console.WriteLine("[4] CERRAR APLICACION");
                option = int.Parse(Console.ReadLine());
                facade = new facade(option);
            } while (option != 4);
        }
    }
}