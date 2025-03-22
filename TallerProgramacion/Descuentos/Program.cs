// Un almacén de escritorios hace los siguientes descuentos: si el cliente compra menos
// de 5 unidades se le da un descuento del 10% sobre la compra; si el número de unidades
// es mayor o igual a cinco pero menos de 10 se le otorga un 20% y, si son 10 o más se le da un 40%.
// Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorio es de $650.000.

Console.Write("¿Cuántos escritorios desea comprar?: ");
var numEscritorio = Console.ReadLine();
int valorEscritorio = 650000;
double valorTotal = 0;

if (int.TryParse(numEscritorio,out int intNumEscritorio))
{
	if (intNumEscritorio != 0)
	{
		if (intNumEscritorio < 5)
		{
			valorTotal = (valorEscritorio*intNumEscritorio) * 0.10;
		}
		else if (intNumEscritorio >= 5 && intNumEscritorio < 10)
		{
            valorTotal = (valorEscritorio * intNumEscritorio) * 0.20;
        }
		else
		{
            valorTotal = (valorEscritorio * intNumEscritorio) * 0.40;
        }

		Console.WriteLine($"Número de escritorios: {intNumEscritorio}");
		Console.WriteLine($"El valor a pagar es: {valorTotal}");
	}
	else
	{
		Console.WriteLine("No compraste nada");
	}
}
else
{
    Console.WriteLine("Ingrese un número entero.");
}
