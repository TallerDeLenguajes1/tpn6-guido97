//Solución creada desde MonoDevelop - Ubuntu


using System;
using static System.Math;

namespace Tp6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int n=InvertirNumero(6543210);
            //Console.WriteLine("n="+ n);

            //Calcular();

            UsandoLibreriaMath();
        }

        private static void UsandoLibreriaMath()
        {
            Console.Write("Ingrese un número: ");
            float num=float.Parse(Console.ReadLine());
            Console.Write("Valor absoluto: " + Abs(num) +
                "\nEl cuadrado: " + Pow(num, 2) +
                "\nLa raíz cuadrada: " + Sqrt(num) +
                "\nEl seno: " + Sin(num) +
                "\nEl Coseno: " + Cos(num) +
                "\nLa parte entera de un tipo float: " + Floor(num)+
                "\n");
            Console.Write("\nAhora ingrese dos números\n" +
            	"Primer número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("El menor es " + Min(num1, num2));
            Console.Write(" y el mayor es "+Max(num1, num2));
        }

        public static int InvertirNumero(int n)
        {
            int aux = 0;
            while (n > 0)
            {
                aux *= 10;
                aux += n % 10;
                n /= 10;
            }
            return aux;
        }

        public static void Calcular()
        {

            Console.WriteLine("Elija una operación\n" +
                "1. Suma\n" +
                "2. Resta\n" +
                "3. Multiplicación\n" +
                "4. División\n" +
                "5. Salir\n");
            try
            {


                int resp = short.Parse(Console.ReadLine());
                if (resp < 5) //hacer cálculo
                {
                    Console.Write("Ingrese el primer valor: ");
                    int v1 = Int16.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo valor: ");
                    int v2 = Int16.Parse(Console.ReadLine());

                    switch (resp)
                    {
                        case 1://suma
                            resp = v1 + v2;
                            break;
                        case 2://resta
                            resp = v1 - v2;
                            break;
                        case 3://Multi
                            resp = v1 * v2;
                            break;
                        case 4://div
                            resp = v1 / v2;
                            break;
                    }
                    Console.Write("\nEl resultado es: " + resp +
                        "\n¿Desea realizar otro cálculo? [S/N]");
                    if (Console.ReadLine().ToUpper()[0] == 'S')
                    {
                        Calcular();
                    }

                }
            }
            catch (Exception ex)
            {
                Calcular();

            }
        }
    }


}

