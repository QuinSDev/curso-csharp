do
{
    Console.Write("Número de créditos: ");
    var numCredito = Console.ReadLine();
    Console.Write("Valor crédito: ");
    var valorCredito = Console.ReadLine();
    Console.Write("Estrato del estudiante: ");
    var estrato = Console.ReadLine();

    double costoMatricula = 0;
    int subsidioAlimentacion = 0;

    if (int.TryParse(numCredito, out int intNumCredito) && int.TryParse(valorCredito, out int intValorNumCredito)
        && int.TryParse(estrato, out int intEstrato))
    {
        if (intNumCredito < 20)
        {
            costoMatricula = intNumCredito * intValorNumCredito;
        }
        else
        {
            var restoCredito = intNumCredito - 20;
            costoMatricula = intValorNumCredito * 20;
            costoMatricula += restoCredito * (intValorNumCredito * 2);
        }

        if (intEstrato == 1)
        {
            costoMatricula *= 0.80;
            subsidioAlimentacion = 200000;
        }
        else if (intEstrato == 2)
        {
            costoMatricula *= 0.50;
            subsidioAlimentacion = 100000;
        }
        else
        {
            costoMatricula *= 0.30;
        }

        Console.WriteLine($"Costo de la matrícula: {costoMatricula}");
        Console.WriteLine($"Valor del subsidio: {subsidioAlimentacion}");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese valores enteros.");
        Console.WriteLine("");
    }
}
while (true);