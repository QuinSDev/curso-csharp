// Elaborar un programa que entre el nombre de un empleado, su salario básico por hora y
// el número de horas trabajadas en el mes; escriba su nombre y salario mensual si éste es
// mayor del salario mínimo, de lo contrario escriba sólo el nombre.

Console.Write("Ingrese el nombre: ");
var nombre = Console.ReadLine();
Console.Write("Número de horas trabajadas en el mes: ");
var horas = Console.ReadLine();
Console.Write("Valor de la hora: ");
var valorHora = Console.ReadLine();
Console.Write("Ingrese el salario mínimo mensual: ");
var salarioMinimo = Console.ReadLine();

if (int.TryParse(horas, out int intHoras) && (int.TryParse(valorHora, out int intValorHora)) 
    && (int.TryParse(salarioMinimo, out int intSalarioMinimo))) 
{
    var salarioMensualEmpleado = intHoras * intValorHora;

    if (salarioMensualEmpleado > intSalarioMinimo)
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Salario mensual: ${salarioMensualEmpleado}");
    }
    else
    {
        Console.WriteLine($"Nombre: {nombre}");
    }
}
