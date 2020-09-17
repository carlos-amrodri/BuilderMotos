using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public abstract class Rodado
    {
        protected string _descripcion;

        public string Descripcion { get { return _descripcion; } }

    }

    public class RodadoChico : Rodado
    {
        public RodadoChico()
        {
            _descripcion = "Mi rodado es 14 pulgadas";
        }
    }

    public class RodadoMediano : Rodado
    {
        public RodadoMediano()
        {
            _descripcion = "Mi rodado es 19 pulgadas";
        }
    }

    public class RodadoGrande : Rodado
    {
        public RodadoGrande()
        {
            _descripcion = "Mi rodado es 22 pulgadas";
        }
    }
}
