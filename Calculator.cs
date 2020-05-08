using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice_I
{
    class Program
    {
        private void multiplicacion(int v1, int v2)
        {
            int res;
            res = v1 * v2;
            return res;

        }
        static void Main(string[] args)
        {
            Suma();
            int num1, num2, resultado;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado es " + resultado);

            Console.Read();


        }
    }
}
