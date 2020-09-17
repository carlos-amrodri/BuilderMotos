using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public class Pistera : BuilderMotos
    {
        public Pistera()
        {
            _descripcion = "Modelo de pista";
        }

        public override Carroceria buildCarroceria()
        {
            return new CarroceriaCarbono();
        }

        public override Motor buildMotor()
        {
            return new MotorGrande();
        }

        public override Rodado buildRodado()
        {
            return new RodadoMediano();
        }
    }
}
