// Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.
Console.Write("Ingrese el primer número: ");
var num1 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el segundo número: ");
var num2 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el tercer número: ");
var num3 = int.Parse(Console.ReadLine()!);

int mayor = num1;

if (num2 > mayor)
{
    mayor = num2;
}

if (num3 > mayor)
{
    mayor = num3;
}

Console.WriteLine("\nEl número mayor es: " + mayor);

