using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Saludar()
        {
            return $"hola mi nombre es {Nombre} y mi apellido es {Apellido}";
        }
    }
}
