using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public class Scooter : BuilderMotos
    {
        public Scooter()
        {
            _descripcion = "Modelo Scooter";
        }

        public override Carroceria buildCarroceria()
        {
            return new CarroceriaHierro();
        }

        public override Motor buildMotor()
        {
            return new MotorChico();
        }

        public override Rodado buildRodado()
        {
            return new RodadoChico();
        }
    }
}
