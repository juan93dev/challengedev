using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public string TipoNombre => "Trapecio";

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public decimal CalcularArea() => (_baseMayor + _baseMenor) / 2 * _altura;

        public decimal CalcularPerimetro()
        {
            var diff = (_baseMayor - _baseMenor) / 2;
            var lateral = (decimal)Math.Sqrt((double)(_altura * _altura + diff * diff));
            return _baseMayor + _baseMenor + 2 * lateral;
        }
    }
}
