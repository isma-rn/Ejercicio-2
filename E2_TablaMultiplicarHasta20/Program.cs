using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_TablaMultiplicarHasta20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número: ");
            int numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0}", ObtenerTabla( 1, 20, numero));

            Console.ReadLine();
        }

        public static string ObtenerTabla(int n1, int n2, int num)
        {
            StringBuilder resultado = new StringBuilder();

            if (n1 < n2)            
                for (int i = n1; i <= n2; i++)                
                    resultado.Append( string.Format( "{0} x {1} = {2}\n", num, i, (num * i) ) );
            else
                resultado.Append("Error");

            return resultado.ToString();
        }
    }
}
