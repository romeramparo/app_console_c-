using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    internal class datos
    {
        public long cedulaempleados { get; set; }
        public string nombresempleados { get; set; }
        public string apellidosempleados { get; set; }
        public string emailempleados { get; set; }
        public string telefonoempleados { get; set; }
        public string departamentoempleados { get; set; }
        public string cargoempleados { get; set; }
        public string codigoempleado { get; set; }
        //public double salarioempleado;
        public datos()
        {
        }
        public datos(long cedulaempleados, string codigoempleado, string nombresempleados, string apellidosempleados, string emailempleados, string telefonoempleados, string departamentoempleados, string cargoempleados)
        {
            this.cedulaempleados = cedulaempleados;
            this.codigoempleado = codigoempleado;
            this.nombresempleados = nombresempleados;
            this.apellidosempleados = apellidosempleados;
            this.emailempleados = emailempleados;
            this.telefonoempleados = telefonoempleados;
            this.departamentoempleados = departamentoempleados;
            this.cargoempleados = cargoempleados;
        }
    }
}
