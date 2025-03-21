// Construir un programa que pida un año y luego determine si el año es bisiesto o no.
// Tenga en cuenta que los años bisiestos son los números múltiplos de 4,
// pero que no son múltiplos de 100 y si son múltiplos de 100 y múltiplos de 400 sí son bisiestos.

Console.Write("Ingrese año: ");
var anio = Console.ReadLine();

if (int.TryParse(anio, out int intAnio)) {

    if (intAnio % 4 == 0 && intAnio % 100 !=0 || intAnio % 400 == 0)
    {
        Console.WriteLine($"El año {intAnio}, es bisiesto.");
    }
    else
    {
        Console.WriteLine($"El año {intAnio}, no es bisiesto.");
    }

}
else
{
    Console.WriteLine("Ingrese los vaolores numéricos del año. No letras");
}

