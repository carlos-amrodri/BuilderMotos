using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMotocicletas
{
    public class Motocicleta
    {
        Motor _motor;
        Carroceria _carroceria;
        Rodado _rodado;
        string _modelo;

        public override string ToString()
        {
            return "El modelo: " + _modelo + "tiene las siguientes características" + _motor.Descripcion + _carroceria.Descripcion + _rodado.Descripcion;
        }

        public Motocicleta (Motor motor, Carroceria carr, Rodado rod, string model)
        {
            _motor = motor;
            _carroceria = carr;
            _rodado = rod;
            _modelo = model;
        }
    }
}
