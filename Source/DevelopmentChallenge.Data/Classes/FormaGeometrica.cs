using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected decimal _lado;
        public int Tipo { get; set; }
        
        protected FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string TraducirForma(Idioma idioma, int cantidad);

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                if (idioma == (int)Idioma.Castellano)
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else if(idioma == (int)Idioma.Italiano)
                    sb.Append("<h1>Lista vuota di forme!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                if (idioma == (int)Idioma.Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else if (idioma == (int)Idioma.Italiano)
                    sb.Append("<h1>Forme report</h1>");
                else
                    // default es inglés
                    sb.Append("<h1>Shapes report</h1>");

                var listaAux = formas.GroupBy(f => f.GetType())
                                   .Select(x => new
                                   {
                                       Tipo = x.Key,
                                       Cantidad = x.Count(),
                                       Area = x.Sum(f => f.CalcularArea()),
                                       Perimetro = x.Sum(f => f.CalcularPerimetro())
                                   }).ToList();

                foreach (var forma in listaAux)
                {
                    sb.Append(ObtenerLinea(forma.Cantidad, forma.Area, forma.Perimetro, formas.First(f => f.GetType() == forma.Tipo), idioma));
                }

                string formadesc = "formas";
                if (idioma == (int)Idioma.Ingles)
                    formadesc = "shapes";
                else if (idioma == (int)Idioma.Italiano)
                    formadesc = "forme";

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append($"{listaAux.Sum(c => c.Cantidad)}" + " " + formadesc + " ");
                sb.Append((idioma == (int)Idioma.Ingles ? "Perimeter " : "Perimetro ") + $"{listaAux.Sum(c => c.Perimetro).ToString("#.##")}" + " ");
                sb.Append("Area " + $"{listaAux.Sum(c => c.Area).ToString("#.##")}");
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaGeometrica formaGeo, int idioma)
        {
            
            if (cantidad > 0)
            {             
                return $"{cantidad} {formaGeo.TraducirForma((Idioma)idioma, cantidad)} | Area {area:#.##} | {(idioma == (int)Idioma.Ingles ? "Perimeter" : "Perimetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
