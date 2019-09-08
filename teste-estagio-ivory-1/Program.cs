using System;

namespace teste_estagio_ivory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int resultado;

            resultado = Calcular(numero);

            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();

               
        }

        static int Calcular(int numero)
        {
            int resultado;

            if(numero <= 0)
            {
                return (0);
            }
            else
            {
                resultado = numero * Calcular(numero - 1);
                return (resultado);
            }
        }
    }
}
