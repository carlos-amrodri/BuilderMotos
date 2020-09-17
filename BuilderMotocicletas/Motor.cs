using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public abstract class Motor
    {
        protected string _descripcion;

        public string Descripcion { get { return _descripcion; } }

    }

    public class MotorChico : Motor
    {
        public MotorChico()
        {
            _descripcion = "Tengo un motor de 50 cc ";
        }

    }

    public class MotorMediano : Motor
    {
        public MotorMediano()
        {
            _descripcion = "Tengo un motor de 250 cc ";
        }
    }

    public class MotorGrande : Motor
    {
        public MotorGrande()
        {
            _descripcion = "Tengo un motor de 500 cc";
        }
    }

}
