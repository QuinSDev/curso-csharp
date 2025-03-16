//Construir un programa que pida un número y luego diga si este número es par o no.

do
{
    Console.Write("Ingresa un número: ");
    var num = int.Parse(Console.ReadLine()!);

    if (num % 2 == 0)
    {
        Console.WriteLine("El número: " + num + ", es par\n");
    }
    else
    {
        Console.WriteLine("El número: " + num + ", es impar\n");
    }
}
while (true);