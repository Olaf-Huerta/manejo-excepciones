using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoExcepciones
{
    class Program
    {
        public class Cuadrado
        {
            int N;

            public Cuadrado(int N)
            {
                this.N = N;
            }

            public int Operacion(int N)
            {

                return N * N;
            }

            ~Cuadrado()
            {
                Console.WriteLine("Memoria Liberada");
            }
        }

        static void Main(string[] args)
        {
            int N, valor;

            Console.WriteLine("-----Cuadrado de un valor entero-----");
            Console.WriteLine();

            try
            {
                Console.Write("Ingrese un valor entero: ");
                N = int.Parse(Console.ReadLine());

                Cuadrado c = new Cuadrado(N);

                valor = c.Operacion(N);

                Console.WriteLine("Valor ingresado al cuadrado: " + valor);

            }
            catch (FormatException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (OverflowException x)
            {
                Console.WriteLine(x.Message);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
