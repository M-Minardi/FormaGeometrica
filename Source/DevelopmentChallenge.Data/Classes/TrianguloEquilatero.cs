﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string TraducirForma(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case Idioma.Ingles:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case Idioma.Italiano:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
            }
            return string.Empty;
        }
    }
}
