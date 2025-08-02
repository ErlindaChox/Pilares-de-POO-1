// Crear una clase Empleando con atributos privados nombre y salario.
class Program
{
    static void Main()
    {
        try
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Ana";
            emp.Salario = 5000;

            Console.WriteLine($"Nombre: {emp.Nombre}");
            Console.WriteLine($"Salario: Q{emp.Salario}");

            // Descomenta para probar errores:
            // emp.Nombre = "";              // Provoca error
            // emp.Salario = -1000;          // Provoca error
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}


