using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {                
        private decimal _baseAbajo;
        private decimal _altura;
        public Trapecio(decimal baseArriba, decimal baseAbajo, decimal altura) : base(baseArriba)  //baseArriba = lado
        {            
            _baseAbajo = baseAbajo;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return ((_lado + _baseAbajo) / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            decimal ladoLateral = (decimal)Math.Sqrt(Math.Pow((double)((_baseAbajo - _lado) / 2), 2) + Math.Pow((double)_altura, 2));
            return _lado + _baseAbajo + (2 * ladoLateral);
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Trapeze" : "Trapezes";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
            }
            return string.Empty;
        }
    }
}
