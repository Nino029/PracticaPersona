using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDomain
{
    public class Empleado : Persona
    {
       
        public double Sueldo { get; set; }

       
        public void ImprimirSueldo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("======SUELDO:=======");
            Console.WriteLine("Sueldo: $" + Sueldo);
        }
    }

}
