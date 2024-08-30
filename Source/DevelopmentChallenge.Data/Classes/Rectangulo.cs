using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal _alto;
        public Rectangulo(decimal ancho, decimal alto) : base(ancho) //_lado = ancho
        {
            _alto = alto;
        }
        public override decimal CalcularArea()
        {
            return _lado * _alto;
        }
        public override decimal CalcularPerimetro()
        {
            return 2 * (_lado + _alto);
        }
        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Rectángulo" : "Rectángulos";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
            }
            return string.Empty;
        }
    }
}
