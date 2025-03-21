// Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
// el del medio y el menor de los números ingresados.

do
{
    Console.Write("Ingrese el primer número: ");
    var num1 = Console.ReadLine();
    Console.Write("Ingrese el segundo número: ");
    var num2 = Console.ReadLine();
    Console.Write("Ingrese el tercer número: ");
    var num3 = Console.ReadLine();

    if (int.TryParse(num1, out int intNum1) && int.TryParse(num2, out int intNum2)
        && int.TryParse(num3, out int intNum3))
    {
        if (intNum1 != intNum2 && intNum1 != intNum3 && intNum2 != intNum3)
        {
            if (intNum1 > intNum2 && intNum1 > intNum3)
            {
                if(intNum2 > intNum3)
                {
                    Console.WriteLine($"El número mayor es: {intNum1}");
                    Console.WriteLine($"El número del medio es: {intNum2}");
                    Console.WriteLine($"El número menor es: {intNum3}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {intNum1}");
                    Console.WriteLine($"El número del medio es: {intNum3}");
                    Console.WriteLine($"El número menor es: {intNum2}");
                }
            }
            else if (intNum2 > intNum1 && intNum2 > intNum3)
            {
                if (intNum1 > intNum3)
                {
                    Console.WriteLine($"El número mayor es: {intNum2}");
                    Console.WriteLine($"El número del medio es: {intNum1}");
                    Console.WriteLine($"El número menor es: {intNum3}");
                } 
                else
                {
                    Console.WriteLine($"El número mayor es: {intNum2}");
                    Console.WriteLine($"El número del medio es: {intNum3}");
                    Console.WriteLine($"El número menor es: {intNum1}");
                }
            }
            else
            {
                if (intNum1 > intNum2)
                {
                    Console.WriteLine($"El número mayor es: {intNum3}");
                    Console.WriteLine($"El número del medio es: {intNum1}");
                    Console.WriteLine($"El número menor es: {intNum2}");
                } 
                else
                {
                    Console.WriteLine($"El número mayor es: {intNum3}");
                    Console.WriteLine($"El número del medio es: {intNum2}");
                    Console.WriteLine($"El número menor es: {intNum1}");
                }
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar tres números diferentes.");
        }
    }
    else
    {
        Console.WriteLine("Debe Ingresar solo numeros");
    }

} while (true);
