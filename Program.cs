using System;

namespace Calcular_el_Error
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma1 = 1/(1+Math.Exp((-1)*(.7921 + .1921)));
            double suma2 = 1/(1+Math.Exp((-1)*(.3887 + .8887)));
            double suma3 = 1/(1+Math.Exp((-1)*(.2741 + .4741)));

            double suma4 = 1/(1+Math.Exp( (-1) * ((suma1 * .202) + (suma2 * .394) + (suma3 * .806) )));

            Console.WriteLine("Neurona 1: " + suma1);
            Console.WriteLine("Neurona 2: " + suma2);
            Console.WriteLine("Neurona 3: " + suma3);
            Console.WriteLine("Salida: " + suma4);
        }
    }
}
