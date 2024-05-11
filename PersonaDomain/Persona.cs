namespace PersonaDomain
{
    public class Persona
    {

        public string? Nombre { get; set; }
        public int Edad { get; set; }


        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("======PERSONA:=======");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }
}

