using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma();
            int num1, num2, resultado;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado es " + resultado);

            Console.Read();


            resta(int a, int b){
                int a, b, resultado;

                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                resultado = a - b;

                Console.WriteLine("El resultado es " + resultado);

                Console.Read();
            }
			
			//DIVISION
			int dividendo = 8;
            int divisor = 4;
            
            Console.WriteLine("El resultado es " + division(dividendo, divisor));

            //MÉTODO DE DIVISIÓN
            double division(int numA, int numB)
            {
                var result = 0;
                result = numA / numB;
                return result;
            }
        }
    }
}
