//Construir un programa que pida un número y luego diga si este número es par o no.

do
{
    Console.Write("Ingresa un número: ");
    var numero = int.Parse(Console.ReadLine()!);

    if (numero % 2 == 0)
    {
        Console.WriteLine("El número: " + numero + ", es par\n");
    }
    else
    {
        Console.WriteLine("El número: " + numero + ", es impar\n");
    }
}
while (true);