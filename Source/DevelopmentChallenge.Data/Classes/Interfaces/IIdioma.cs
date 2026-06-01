namespace DevelopmentChallenge.Data.Classes
{
    public interface IIdioma
    {
        string Encabezado { get; }
        string ListaVacia { get; }
        string LabelFormas { get; }
        string LabelPerimetro { get; }
        string TraducirForma(string tipoNombre, int cantidad);
    }
}
