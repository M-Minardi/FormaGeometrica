using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado): base(lado) 
        {
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Circle" : "Circles";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
            }
            return string.Empty;
        }
    }
}
