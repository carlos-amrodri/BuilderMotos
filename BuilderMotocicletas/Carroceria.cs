using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public abstract class Carroceria
    {
        protected string _descripcion;

        public string Descripcion { get { return _descripcion; } }

    }

    public class CarroceriaHierro : Carroceria
    {
        public CarroceriaHierro()
        {
            _descripcion = "Mi carrocer{ia es de hierro";
        }
    }

    public class CarroceriaAluminio : Carroceria
    {
        public CarroceriaAluminio()
        {
            _descripcion = "Mi carrocer{ia es de aluminio";
        }
    }

    public class CarroceriaCarbono : Carroceria
    {
        public CarroceriaCarbono ()
        {
            _descripcion = "Mi carrocer{ia es de Carbono";
        }
    }
}
