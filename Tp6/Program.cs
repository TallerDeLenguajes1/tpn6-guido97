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

            //UsandoLibreriaMath();

            UsandoStrings();

        }

        private static void UsandoStrings()
        {
            String[] op = { "Suma", "Resta", "Multiplicación", "División" };

            //Console.Write("\nIngrese una cadena de texto: ");
            //string s = Console.ReadLine();

            //int tamString = s.Length / 2;
            //Console.Write("Ultima mitad de caracteres: " + s.Substring(tamString) +
            //"\nCantidad de caracteres: " + s.Length +
            //"\nConcateno la segunda mitad con la primera: " + s.Substring(tamString)
            //+ s.Substring(0, tamString));

            ////Console.WriteLine("\nElija una operación\n" +
            ////    "1. Suma\n" +
            ////    "2. Resta\n" +
            ////    "3. Multiplicación\n" +
            ////    "4. División\n");
            ////int opUsuario=short.Parse(Console.ReadLine());

            ////int v1 = 5;
            ////int v2 = 6;
            ////int resp = Calcular(opUsuario, v1, v2);
            ////Console.Write("La "+op[opUsuario - 1]+" de {0} y de {1} es {2}",v1,v2,resp);


            //Console.Write("\nSe mostrará la cadena caracter a caracter: ");

            //foreach (var item in s)
            //{
            //    Console.Write(item);
            //}

            //string busqueda = s.Contains("Ubuntu") ? "Si" : "No";
            //Console.Write("\nBuscando Ubuntu: " + busqueda + " se encontró");

            //Console.Write("\nCadena en mayúsculas: " + s.ToUpper() +
            //"\nCadena en minúsculas: " + s.ToLower());

            //Console.Write("\nIngrese una cadena (para comparar): ");
            //string s2 = Console.ReadLine();
            //int comparar = string.Compare(s, s2, StringComparison.Ordinal);
            //string quesignifica = " está antes que \"";
            //if (comparar > 0)
            //{
            //    quesignifica = "\"" + s2 + "\" (la segunda cadena)" + quesignifica + s + "\" (la primera)";
            //}
            //else if (comparar < 0)
            //{
            //    quesignifica = "la primera" + s + quesignifica + s2 + "(la segunda cadena)";
            //}
            //else quesignifica = "son iguales";
            //Console.Write("Comparando con \"Compare\" el resultado es {0}" +
            //    " lo que significa que {1}", comparar, quesignifica);

            //Console.Write("\n\nAhora ingrese una cadena, la separaremos por ':' : ");
            //string separar = Console.ReadLine();
            //Console.Write("Separada queda: ");
            //foreach (var item in separar.Split(':'))
            //{
            //    Console.Write(item + " ");
            //}

            Console.WriteLine("\nProbemos la calculadora! ingrese una operación simple (solo 1 operador): ");
            string resolver = Console.ReadLine();
            char[] operadores = { '+', '-', '*', '/' };
            int cont = 0;
            foreach (var item in operadores)
            {
                if (resolver.Contains(item.ToString()))
                    break;
                cont++;
            }
            string[] valores = resolver.Split(operadores[cont]);
            Console.Write("El resultado es: "+
            Calcular(cont+1, short.Parse(valores[0]), short.Parse(valores[1])));
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


                    resp = Calcular(resp, v1, v2);
                    Console.Write("\nEl resultado es: " + resp +
                        "\n¿Desea realizar otro cálculo? [S/N]]");
                    if (Console.ReadLine().ToUpper()[0] == 'S')
                    {
                        Calcular();
                    }

                }
            }
            catch (Exception)
            {
                Calcular();

            }
        }

        private static int Calcular(int resp, int v1, int v2)
        {
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
            return resp;
        }
    }


}

