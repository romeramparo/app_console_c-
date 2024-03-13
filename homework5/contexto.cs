using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    
    internal class contexto
    {
        Istrategy strategy;
        public contexto(Istrategy nombre)
        {
            this.strategy = nombre;
        }
        public void run(string valor)
        {
            strategy.SalvarEmpleado(valor);
        }
    }
}
