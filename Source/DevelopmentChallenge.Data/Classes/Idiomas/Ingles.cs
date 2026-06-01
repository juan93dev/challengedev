using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : IIdioma
    {
        public string Encabezado => "Shapes report";
        public string ListaVacia => "Empty list of shapes!";
        public string LabelFormas => "shapes";
        public string LabelPerimetro => "Perimeter";

        private static readonly Dictionary<string, string[]> Traducciones =
            new Dictionary<string, string[]>
            {
                { "Cuadrado",           new[] { "Square",    "Squares"    } },
                { "Circulo",            new[] { "Circle",    "Circles"    } },
                { "TrianguloEquilatero", new[] { "Triangle",  "Triangles"  } },
                { "Trapecio",           new[] { "Trapezoid", "Trapezoids" } }
            };

        public string TraducirForma(string tipoNombre, int cantidad)
        {
            if (Traducciones.TryGetValue(tipoNombre, out var nombres))
                return cantidad == 1 ? nombres[0] : nombres[1];
            return tipoNombre;
        }
    }
}
