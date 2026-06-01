using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Castellano : IIdioma
    {
        public string Encabezado => "Reporte de Formas";
        public string ListaVacia => "Lista vacía de formas!";
        public string LabelFormas => "formas";
        public string LabelPerimetro => "Perimetro";

        private static readonly Dictionary<string, string[]> Traducciones =
            new Dictionary<string, string[]>
            {
                { "Cuadrado",           new[] { "Cuadrado",  "Cuadrados"  } },
                { "Circulo",            new[] { "Círculo",   "Círculos"   } },
                { "TrianguloEquilatero", new[] { "Triángulo", "Triángulos" } },
                { "Trapecio",           new[] { "Trapecio",  "Trapecios"  } }
            };

        public string TraducirForma(string tipoNombre, int cantidad)
        {
            if (Traducciones.TryGetValue(tipoNombre, out var nombres))
                return cantidad == 1 ? nombres[0] : nombres[1];
            return tipoNombre;
        }
    }
}
