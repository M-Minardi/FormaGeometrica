using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Square" : "Squares";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
            }
            return string.Empty;
        }
    }
}
