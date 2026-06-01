using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ReporteFormas
    {
        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{idioma.ListaVacia}</h1>");
                return sb.ToString();
            }

            sb.Append($"<h1>{idioma.Encabezado}</h1>");

            decimal totalArea = 0;
            decimal totalPerimetro = 0;
            int totalFormas = 0;

            foreach (var grupo in formas.GroupBy(f => f.TipoNombre))
            {
                int cantidad = grupo.Count();
                decimal area = grupo.Sum(f => f.CalcularArea());
                decimal perimetro = grupo.Sum(f => f.CalcularPerimetro());

                totalArea += area;
                totalPerimetro += perimetro;
                totalFormas += cantidad;

                sb.Append($"{cantidad} {idioma.TraducirForma(grupo.Key, cantidad)} | Area {area.ToString("#.##", CultureInfo.InvariantCulture)} | {idioma.LabelPerimetro} {perimetro.ToString("#.##", CultureInfo.InvariantCulture)} <br/>");
            }

            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalFormas} {idioma.LabelFormas} {idioma.LabelPerimetro} {totalPerimetro.ToString("#.##", CultureInfo.InvariantCulture)} Area {totalArea.ToString("#.##", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
