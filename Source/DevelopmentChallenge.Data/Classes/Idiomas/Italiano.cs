using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        public string Encabezado => "Rapporto sulle Forme";
        public string ListaVacia => "Lista vuota di forme!";
        public string LabelFormas => "forme";
        public string LabelPerimetro => "Perimetro";

        private static readonly Dictionary<string, string[]> Traducciones =
            new Dictionary<string, string[]>
            {
                { "Cuadrado",           new[] { "Quadrato",  "Quadrati"  } },
                { "Circulo",            new[] { "Cerchio",   "Cerchi"    } },
                { "TrianguloEquilatero", new[] { "Triangolo", "Triangoli" } },
                { "Trapecio",           new[] { "Trapezio",  "Trapezi"   } }
            };

        public string TraducirForma(string tipoNombre, int cantidad)
        {
            if (Traducciones.TryGetValue(tipoNombre, out var nombres))
                return cantidad == 1 ? nombres[0] : nombres[1];
            return tipoNombre;
        }
    }
}
