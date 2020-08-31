using System;

namespace ProgramaQueRealizaOperacionesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string dato = "";
            int opcion = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            //Presentamos menu
            do
            {
                Console.WriteLine("1-->Suma  2-->Resta  3-->Multiplicacion  4-->Division  5-->Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                if (opcion == 1)
                    suma();

                if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    dato = Console.ReadLine();
                    a = Convert.ToDouble(dato);

                    Console.WriteLine("Ingrese el segundo numero");
                    dato = Console.ReadLine();
                    b = Convert.ToDouble(dato);

                    resta(a, b);
                }

                if (opcion == 3)
                {
                    c = multi();

                    Console.WriteLine("El resultado de la multiplicación es:{0}", c);
                }

                if (opcion == 4)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    dato = Console.ReadLine();
                    a = Convert.ToDouble(dato);

                    Console.WriteLine("Ingrese el segundo numero");
                    dato = Console.ReadLine();
                    b = Convert.ToDouble(dato);

                    c = div(a, b);

                    Console.WriteLine("El resultado de la división es:{0}", c);
                }
            } while (opcion != 5);
        }

        //Metodo que solo ejecuta codigo
        public static void suma()
        {
            double x = 0;
            double y = 0;
            double resul = 0;
            string valor = "";

            Console.WriteLine("Ingrese el rpimero numero");
            valor = Console.ReadLine();
            x = Convert.ToDouble(valor);

            Console.WriteLine("Ingrese el segundo numero");
            valor = Console.ReadLine();
            y = Convert.ToDouble(valor);

            resul = x + y;

            Console.WriteLine("El resultado de la suma es: {0}", resul);
        }

        //Metodo que recibe valores
        public static void resta(double x, double y)
        {
            double resul = 0;

            resul = x - y;

            Console.WriteLine("El resultado de la resta es {0}", resul);
        }

        //Metodo que regresa valores
        public static double multi()
        {
            double x = 0;
            double y = 0;
            double resul = 0;
            string valor = "";

            Console.WriteLine("Ingrese el primer numero");
            valor = Console.ReadLine();
            x = Convert.ToDouble(valor);

            Console.WriteLine("Ingrese el segundo numero");
            valor = Console.ReadLine();
            y = Convert.ToDouble(valor);

            resul = x * y;

            return resul;
        }

        //Metodos que reciben parametros y regresan valor
        public static double div(double x,double y)
        {
            double resul = 0;

            resul = x / y;

            return resul;
        }
    }
}
