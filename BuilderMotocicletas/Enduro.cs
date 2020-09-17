using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public class Enduro : BuilderMotos
    {
        public Enduro()
        {
            _descripcion = "Modelo enduro";
        }

        public override Carroceria buildCarroceria()
        {
            return new CarroceriaAluminio();
        }

        public override Motor buildMotor()
        {
            return new MotorMediano();
        }

        public override Rodado buildRodado()
        {
            return new RodadoGrande();
        }
    }
}
