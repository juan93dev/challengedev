# Development Challenge

Refactorización de `FormaGeometrica` aplicando principios OOP.

## Qué se hizo

La clase original concentraba toda la lógica: cálculos geométricos, traducciones y generación del reporte. Agregar una forma o un idioma nuevo requería modificar la clase en múltiples lugares.

La solución separa esas responsabilidades:

- `IFormaGeometrica` — contrato para cualquier forma geométrica
- `IIdioma` — contrato para cualquier idioma
- `Formas/` — una clase por forma (`Cuadrado`, `Circulo`, `TrianguloEquilatero`, `Trapecio`)
- `Idiomas/` — una clase por idioma (`Castellano`, `Ingles`, `Italiano`)
- `ReporteFormas` — genera el reporte sin conocer formas ni idiomas concretos

Agregar una forma nueva: crear una clase que implemente `IFormaGeometrica`.  
Agregar un idioma nuevo: crear una clase que implemente `IIdioma`.

## Tests

11 tests con NUnit. Para correrlos:
