using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _diametro;

        public string TipoNombre => "Circulo";

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public decimal CalcularArea() => (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);

        public decimal CalcularPerimetro() => (decimal)Math.PI * _diametro;
    }
}
