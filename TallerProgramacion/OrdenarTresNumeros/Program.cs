//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y
//el menor de los números ingresados.

Console.Write("Ingrese el primer número: ");
var num1 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el segundo número: ");
var num2 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el tercer número: ");
var num3 = int.Parse(Console.ReadLine()!);

int mayor;

if (num1 > num2 && num1 > num3)
{
    mayor = num1;

    if (num2 > num3)
    {
        mayor = num2;

    }
    else
    {
        mayor = num3;
    }
}
else if (num2 > num1 && num2 > num3)
{
    mayor = num2;
    if (num1 > num3)
    {
        mayor = num1;
    }
    else
    {
        mayor = num3;
    }
}
else if (num3 > num1 && num3 > num2)
{
    mayor = num3;
    if (num1 > num2)
    {
        mayor = num1;
    }
    else
    {
        mayor = num2;
    }
}

Console.Write("El número mayor es: ", mayor);
