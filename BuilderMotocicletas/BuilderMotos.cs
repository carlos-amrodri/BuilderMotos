using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public abstract class BuilderMotos
    {
        protected string _descripcion;
        public abstract Motor buildMotor();
        public abstract Carroceria buildCarroceria();
        public abstract Rodado buildRodado();

        public string Descripcion { get { return _descripcion; } }

        public Motocicleta buildMotocicleta()
        {
            Motor motor = buildMotor();
            Carroceria carroceria = buildCarroceria();
            Rodado rodado = buildRodado();
            return new Motocicleta(motor, carroceria, rodado,_descripcion);
        }
    }


}
