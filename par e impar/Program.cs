using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {

            double Numero1;
            double respuesta;



            Console.WriteLine("Ingresa el numero:");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            respuesta = Numero1 % 2;

            if (respuesta == 0)
            {
                Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero es impar.");
            }
            Console.ReadKey();





        }
    }
}
