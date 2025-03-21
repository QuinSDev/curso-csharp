// Construir un programa que pida dos número y diga si el segundo es múltiplo del primero.

do
{
    Console.Write("Ingrese el primer número: ");
    var num1 = Console.ReadLine();
    Console.Write("Ingrese el segundo número: ");
    var num2 = Console.ReadLine();

    if (int.TryParse(num1, out int intNum1) && int.TryParse(num2, out int intNum2))
    {
            if (intNum1 == 0)
            {
                Console.WriteLine("No se puede dividir por cero. Intente de nuevo.");
            }
            else if (intNum2 % intNum1 == 0)
            {
                Console.WriteLine($"El número {intNum2}, es múltiplo de {intNum1}");
            }
            else
            {
                Console.WriteLine($"El número {intNum2}, no es múltiplo de {intNum1}");
            }

    }
    else
    {
        Console.WriteLine("Debes ingresar solo números enteros.");
    }

} while (true);
