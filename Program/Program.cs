using PersonaDomain;
class Program
{
    static void Main(string[] args)
    {

        Persona persona = new Persona
        {

            Nombre = "Juan",
            Edad = 30
        };

     
        persona.Imprimir();

      
        Empleado empleado = new Empleado
        {
            Nombre = "María",
            Edad = 25,
            Sueldo = 3000
        };

        empleado.Imprimir();

  
        empleado.ImprimirSueldo();

       
        Console.ReadKey();
    }
}